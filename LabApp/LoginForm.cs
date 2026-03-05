using LabApp.TBD_But;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
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
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

            this.Hide();
            registerForm.FormClosed += (s, ec) => this.Close();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = this.LoginField.Text.Trim();
            string password = this.PasswordField.Text;

            // Find a user
            var user = DbDataAccess.LoadUser(username);

            // If user not found, show error
            if (user == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            // Verify password
            bool PasswordOk = PasswordHelper.VerifyPassword(password, user.PasswordHash);


            if (!PasswordOk)
            {
                MessageBox.Show("Incorrect password.");
                return;
            }

            // Log in the user  
            UserSession.Login(user);

            this.Hide();

            // Redirect to homepage
            Homepage homepage = new Homepage();
            homepage.FormClosed += (s, ec) =>
            {
                if (homepage.IsLogout)
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
            homepage.Show();
        }
    }
}


