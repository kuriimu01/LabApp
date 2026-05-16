using Emgu.CV;
using Emgu.CV.Structure;
using LabApp.Security;
using LabApp.TBD_But;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LabApp.Forms
{
    public partial class BiometricLogin : Form
    {
        private VideoCapture _capture;
        private bool _isCapturing = false;
        private DateTime _lastProcessed = DateTime.Now;
        public UserModel AuthenticatedUser { get; private set; } = null;

        public BiometricLogin()
        {
            InitializeComponent();
        }

        private async void BiometricLogin_Load(object sender, EventArgs e)
        {
            try
            {

                if (!BiometricService.IsModelTrained)
                {
                    MessageBox.Show("Біометрична база порожня. Спочатку зареєструйте обличчя.");
                    this.Close();
                    return;
                }

                StatusLabel.Text = "Активація камери, зачекайте...";

                // Асинхронний запуск камери: форма відкривається миттєво і не зависає
                await System.Threading.Tasks.Task.Run(() =>
                {
                    _capture = new VideoCapture(0);
                });

                Application.Idle += ProcessFrame;
                _isCapturing = true;
                StatusLabel.Text = "Подивіться в камеру";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка ініціалізації: {ex.Message}");
                this.Close();
            }
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (!_isCapturing || _capture == null) return;

            // Обмежуємо частоту кадрів (10 разів на секунду) для зняття навантаження з ЦП
            if ((DateTime.Now - _lastProcessed).TotalMilliseconds < 100) return;
            _lastProcessed = DateTime.Now;

            try
            {
                using (Mat frame = _capture.QueryFrame())
                {
                    if (frame == null || frame.IsEmpty) return;

                    using (Image<Gray, byte> grayFrame = frame.ToImage<Gray, byte>())
                    using (Image<Bgr, byte> displayFrame = frame.ToImage<Bgr, byte>())
                    {
                        Rectangle[] faces = BiometricService.DetectFaces(grayFrame);

                        foreach (var face in faces)
                        {
                            displayFrame.Draw(face, new Bgr(Color.Red), 2);
                            grayFrame.ROI = face;

                            using (Image<Gray, byte> detectedFace = grayFrame.Copy())
                            {
                                // Нормалізація освітлення для стабілізації дистанції
                                detectedFace._EqualizeHist();

                                var result = BiometricService.PredictUser(detectedFace);

                                this.Invoke((MethodInvoker)delegate {
                                    StatusLabel.Text = $"ID: {result.Label}, Dist: {result.Distance:F0}";
                                });

                                // ВИПРАВЛЕННЯ: Поріг збільшено до 100.
                                // Дистанція 70-90 тепер вважається успішним розпізнаванням.
                                if (result.Distance < 100 && result.Label != -1)
                                {
                                    // ВИПРАВЛЕННЯ: Блокування фантомних ID з пошкодженої моделі
                                    var allUsers = DbDataAccess.LoadUsers();
                                    if (allUsers.Any(u => u.Id == result.Label))
                                    {
                                        AuthenticateUserById(result.Label);
                                        return; // Зупиняємо цикл, переходимо до входу
                                    }
                                }
                            }
                        }

                        // Безпечне оновлення PictureBox без витоку пам'яті
                        Image old = CameraBox.Image;
                        CameraBox.Image = displayFrame.ToBitmap();
                        if (old != null) old.Dispose();
                    }
                }
            }
            catch
            {
                // Ігноруємо помилки переривання потоку при закритті форми
            }
        }

        private void AuthenticateUserById(int userId)
        {
            // 1. Негайно відключаємо обробник кадрів
            _isCapturing = false;
            Application.Idle -= ProcessFrame;

            // 2. Завантажуємо користувача
            var users = DbDataAccess.LoadUsers();
            var user = users.Find(u => u.Id == userId);

            if (user != null)
            {
                AuthenticatedUser = user;

                // 3. Асинхронне безпечне закриття форми (уникає мертвих блокувань)
                this.BeginInvoke((MethodInvoker)delegate {
                    if (_capture != null)
                    {
                        _capture.Stop();
                        _capture.Dispose();
                        _capture = null;
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                });
            }
            else
            {
                // Резервний варіант: якщо користувача з якоїсь причини не знайдено, відновлюємо пошук
                _isCapturing = true;
                Application.Idle += ProcessFrame;
            }
        }

        private void BiometricLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Гарантоване знищення камери при закритті форми хрестиком
            _isCapturing = false;
            Application.Idle -= ProcessFrame;

            if (_capture != null)
            {
                _capture.Stop();
                _capture.Dispose();
                _capture = null;
            }
        }
    }
}