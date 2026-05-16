using LabApp.Forms;
using LabApp.TBD_But;
using LabApp.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabApp
{
    public partial class Login : Form
    {
        System.Diagnostics.Stopwatch typingTimer = new System.Diagnostics.Stopwatch();
        int charCount = 0;

        public Login()
        {
            InitializeComponent();
            this.PasswordField.AutoSize = false;
            this.PasswordField.Size = new Size(this.PasswordField.Size.Width, this.LoginField.Size.Height);
            this.errorLabel.Text = "";

            // Блокуємо Copy-Paste
            this.PasswordField.ShortcutsEnabled = false;

            // Прив'язуємо подію для таймера
            this.PasswordField.KeyPress += PasswordField_KeyPress;
        }

        private void PasswordField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!typingTimer.IsRunning) typingTimer.Start();
            charCount++;
        }

        void ValidateForm()
        {
            bool usernameValid = ValidateUser.IsUsernameValid(
                this.LoginField.Text,
                out string usernameError);

            bool passwordValid = ValidateUser.IsPasswordValid(
                this.PasswordField.Text,
                this.StrongPassCheckbox.Checked,
                out string passwordError);

            if (!usernameValid)
            {
                this.errorLabel.Text = usernameError;
            }
            else if (!passwordValid)
            {
                this.errorLabel.Text = passwordError;
            }
            else
            {
                this.errorLabel.Text = "";
            }

            LogInButton.Enabled = usernameValid && passwordValid;

        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void StrongPassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void SignInRedirect_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();

            this.Hide();
            registerForm.FormClosed += (s, ec) => this.Close();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            typingTimer.Stop();

            if (charCount > 0 && (typingTimer.ElapsedMilliseconds / charCount) < 40)
            {
                MessageBox.Show("Виявлено автоматичне введення пароля! Вхід заблоковано.");
                ResetTypingMetrics();
                return;
            }

            string username = this.LoginField.Text.Trim();
            string password = this.PasswordField.Text;

            // Пробуємо авторизуватися
            bool isAuthenticated = UserService.Authenticate(username, password, out UserModel user, out string loginError);

            // СЦЕНАРІЙ 1: Пароль вірний, але термін дії минув
            if (!isAuthenticated && user != null && loginError.Contains("Термін дії пароля минув"))
            {
                MessageBox.Show(loginError + "\nЗараз відкриється вікно зміни пароля.", "Необхідне оновлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Тимчасово авторизуємо користувача, щоб він міг змінити пароль
                UserSession.Login(user);

                using (ChangePassword changePassForm = new ChangePassword())
                {
                    changePassForm.ShowDialog(); // Відкриваємо модально
                }

                // Після закриття вікна зміни пароля розлогінюємо, щоб він зайшов уже з новим паролем
                UserSession.Logout();
                this.PasswordField.Text = "";
                ResetTypingMetrics();
                return;
            }

            // СЦЕНАРІЙ 2: Звичайна помилка (невірний пароль, блок тощо)
            if (!isAuthenticated)
            {
                MessageBox.Show(loginError, "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetTypingMetrics();
                return;
            }

            // СЦЕНАРІЙ 3: Успішний вхід
            UserSession.Login(user);
            ResetTypingMetrics();

            this.Hide();
            Form nextForm = (user.IsAdmin == 1) ? (Form)new AdminPannel() : (Form)new Homepage();
            nextForm.FormClosed += (s, ec) =>
            {
                if (nextForm is Homepage hp && hp.IsLogout)
                {
                    this.LoginField.Text = "";
                    this.PasswordField.Text = "";
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            };
            nextForm.Show();
        }
        private void ResetTypingMetrics()
        {
            typingTimer.Reset();
            charCount = 0;
            this.PasswordField.Text = "";
        }

        private void TestBot_Click(object sender, EventArgs e)
        {
            // 1. Очищаємо все перед тестом
            ResetTypingMetrics();
            this.LoginField.Text = "bot_test_user"; // Заповнюємо логін (можеш змінити на існуючий)

            string botPassword = "SuperFastPassword123!";

            // 2. Симулюємо надшвидке посимвольне введення (цикл відпрацює за 0.001 секунди)
            foreach (char c in botPassword)
            {
                this.PasswordField.Text += c;

                // Вручну викликаємо обробник події, ніби клавіша була реально натиснута
                PasswordField_KeyPress(this, new KeyPressEventArgs(c));
            }

            // 3. Одразу ж програмно "натискаємо" кнопку Увійти
            LogInButton_Click(sender, e);
        }

        private void BiometricLoginButton_Click(object sender, EventArgs e)
        {
            using (LabApp.Forms.BiometricLogin bioForm = new LabApp.Forms.BiometricLogin())
            {
                if (bioForm.ShowDialog() == DialogResult.OK && bioForm.AuthenticatedUser != null)
                {
                    // СЦЕНАРІЙ: Успішний біометричний вхід
                    UserSession.Login(bioForm.AuthenticatedUser);

                    this.Hide();
                    Form nextForm = (bioForm.AuthenticatedUser.IsAdmin == 1) ? (Form)new AdminPannel() : (Form)new Homepage();
                    nextForm.FormClosed += (s, ec) =>
                    {
                        if (nextForm is Homepage hp && hp.IsLogout)
                        {
                            this.Show();
                        }
                        else
                        {
                            this.Close();
                        }
                    };
                    nextForm.Show();
                }
            }
        }

        private void AddFace_Click(object sender, EventArgs e)
        {
            // Зчитуємо логін, який користувач ввів у поле
            string username = this.LoginField.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Будь ласка, введіть ваш логін у поле для входу перед реєстрацією обличчя.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Шукаємо користувача в базі даних за введеним логіном
            UserModel targetUser = DbDataAccess.LoadUser(username);

            if (targetUser == null)
            {
                MessageBox.Show("Користувача з таким логіном не знайдено! Спочатку зареєструйтесь у системі.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Відкриваємо форму реєстрації, передаючи знайденого користувача
            using (LabApp.Forms.FaceRegistration faceRegForm = new LabApp.Forms.FaceRegistration(targetUser))
            {
                this.Hide(); // Тимчасово ховаємо форму логіну

                faceRegForm.ShowDialog(); // Відкриваємо форму реєстрації обличчя

                this.Show(); // Показуємо форму логіну знову, коли реєстрація завершиться
            }
        }
    }
}


