using Emgu.CV;
using Emgu.CV.Structure;
using LabApp.Security;
using LabApp.TBD_But;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LabApp.Forms
{
    public partial class FaceRegistration : Form
    {
        private VideoCapture _capture;
        private List<Image<Gray, byte>> _capturedFaces = new List<Image<Gray, byte>>();
        private int _sampleLimit = 100; // Рекомендовано для надійної бази LBPH
        private UserModel _targetUser;
        private bool _isTraining = false;
        private DateTime _lastProcessed = DateTime.Now;

        public FaceRegistration(UserModel user)
        {
            InitializeComponent();
            _targetUser = user;
            lblUserInfo.Text = $"Реєстрація обличчя для: {user.Username}";
        }

        private async void FaceRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                lblProgress.Text = "Активація камери...";

                // АСИНХРОННИЙ ЗАПУСК: форма з'являється миттєво і не зависає
                await System.Threading.Tasks.Task.Run(() =>
                {
                    _capture = new VideoCapture(0);
                });

                Application.Idle += ProcessFrame;
                lblProgress.Text = $"Зібрано: 0 / {_sampleLimit}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка ініціалізації камери:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_capture == null || _isTraining) return;

            // Обмежуємо частоту кадрів до ~15 FPS, щоб уникнути лагів інтерфейсу
            if ((DateTime.Now - _lastProcessed).TotalMilliseconds < 66) return;
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

                        if (faces.Length > 0)
                        {
                            var faceRect = faces[0];
                            displayFrame.Draw(faceRect, new Bgr(Color.Green), 2);

                            // Збираємо зразки
                            if (_capturedFaces.Count < _sampleLimit)
                            {
                                grayFrame.ROI = faceRect;
                                Image<Gray, byte> faceImage = grayFrame.Copy().Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);

                                // ВАЖЛИВО: Нормалізація освітлення під час реєстрації
                                faceImage._EqualizeHist();

                                _capturedFaces.Add(faceImage);
                                grayFrame.ROI = Rectangle.Empty;

                                // Безпечне оновлення тексту в інтерфейсі
                                this.Invoke((MethodInvoker)delegate {
                                    lblProgress.Text = $"Зібрано: {_capturedFaces.Count} / {_sampleLimit}";
                                });
                            }
                            else if (_capturedFaces.Count == _sampleLimit)
                            {
                                // Ліміт досягнуто - запускаємо збереження
                                StopAndTrain();
                                return;
                            }
                        }

                        // Безпечне відображення кадру (очищення пам'яті)
                        Image oldImage = pbCamera.Image;
                        pbCamera.Image = displayFrame.ToBitmap();
                        if (oldImage != null) oldImage.Dispose();
                    }
                }
            }
            catch { /* Ігноруємо помилки переривання потоку при закритті форми */ }
        }

        private void StopAndTrain()
        {
            _isTraining = true;
            Application.Idle -= ProcessFrame; // Зупиняємо камеру

            this.Invoke((MethodInvoker)delegate {
                lblProgress.Text = "Навчання моделі та збереження, зачекайте...";
            });

            // АСИНХРОННЕ ЗБЕРЕЖЕННЯ: Інтерфейс більше не зависне "намертво"
            System.Threading.Tasks.Task.Run(() =>
            {
                try
                {
                    BiometricService.TrainModel(_targetUser.Id, _capturedFaces);

                    // Повертаємось у головний потік для відображення повідомлення і закриття
                    this.Invoke((MethodInvoker)delegate {
                        MessageBox.Show($"Біометричний профіль для {_targetUser.Username} успішно створено!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate {
                        MessageBox.Show($"Помилка під час збереження моделі:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    });
                }
            });
        }

        private void FaceRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Надійне вимкнення камери при закритті форми хрестиком
            _isTraining = true;
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