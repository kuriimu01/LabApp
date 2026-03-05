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
    
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.PasswordField.AutoSize = false;
            this.PasswordField.Size = new Size(this.PasswordField.Size.Width, this.LoginField.Size.Height);
            this.errorLabel.Text = "";
            this.StrongPassCheckbox.Checked = true;
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

            if (!usernameValid) {
                this.errorLabel.Text = usernameError;
            }else if (!passwordValid) {
                this.errorLabel.Text = passwordError;
            } else {
                this.errorLabel.Text = "";
            }

            logInButton.Enabled = usernameValid && passwordValid;

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
            if (!StrongPassCheckbox.Checked)
            {
                using (CheckAdmin adminForm = new CheckAdmin())
                {
                    var result = adminForm.ShowDialog();

                    if (result != DialogResult.OK || !adminForm.IsAuthorized)
                    {
                        MessageBox.Show(
                            "Admin authorization required.",
                            "Access denied",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        StrongPassCheckbox.Checked = true;
                        return;
                    }
                }
            }
            ValidateForm();
        }

        private void LogInRedirect_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = this.LoginField.Text.Trim();
            string password = this.PasswordField.Text;
            int useStrongPass = this.StrongPassCheckbox.Checked ? 1 : 0;


            // Check if user already exists
            UserModel existingUser = DbDataAccess.LoadUser(username);
            if (existingUser != null)
            {
                errorLabel.Text = "User already exists.";
                return;
            }

            // Hash the password
            string passwordHash = PasswordHelper.HashPassword(password);

            // Create new user model
            UserModel NewUser = new UserModel
            {
                Username = username,
                PasswordHash = passwordHash,
                UseStrongPassword = useStrongPass
            };

            // Save the new user to the database
            DbDataAccess.SaveUser(NewUser);

            MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
