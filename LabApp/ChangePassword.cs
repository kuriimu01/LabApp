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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            this.IsStrongPassword.Text = "Strong password required: " + (UserSession.CurrentUser.UseStrongPassword != 0);
            this.errorLabel.Text = "";
        }
        void ValidateForm()
        {
            bool passwordValid = ValidateUser.IsPasswordValid(
                this.NewPasswordField.Text,
                UserSession.CurrentUser.UseStrongPassword != 0,
                out string passwordError
            );

            if (!passwordValid)
            {
                this.errorLabel.Text = passwordError;
            }
            else
            {
                this.errorLabel.Text = "";
            }

            ChangePassButton.Enabled = passwordValid;
        }


        private void NewPasswordField_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void StrongPassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }
        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            string newPassword = this.NewPasswordField.Text;
            string confirmedPassword = this.ConfirmPasswordField.Text;

            // Ensure user is authenticated before allowing password change
            if (!UserSession.IsAuthenticated())
            {
                MessageBox.Show("User is not authenticated.");
                this.Close();
                return;
            }
            // Get the current user from the session
            UserModel user = UserSession.CurrentUser;
            // Validate that the new password and confirmation match
            if (newPassword != confirmedPassword)
            {
                this.errorLabel.Text = "Passwords do not match.";
                return;
            }
            // Validate the new password 
            if (!ValidateUser.IsPasswordValid(newPassword, UserSession.CurrentUser.UseStrongPassword != 0, out string passwordError))
            {
                this.errorLabel.Text = passwordError;
                return;
            }
            // Update the user's password hash in the database
            user.PasswordHash = PasswordHelper.HashPassword(newPassword);
            DbDataAccess.UpdateUser(user);

            MessageBox.Show("Password changed successfully.");
            this.Close();
        }

        private void BackToHomepage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
