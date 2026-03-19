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
        public Login()
        {
            InitializeComponent();

            this.PasswordField.AutoSize = false;
            this.PasswordField.Size = new Size(this.PasswordField.Size.Width, this.LoginField.Size.Height);
            this.errorLabel.Text = "";
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
            string username = this.LoginField.Text.Trim();
            string password = this.PasswordField.Text;

            if (!UserService.Authenticate(username, password, out UserModel user))
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            UserSession.Login(user);

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

    }
}


