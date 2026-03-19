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
            if (!UserSession.IsAuthenticated)
            {
                MessageBox.Show("User is not authenticated.");
                this.Close();
                return;
            }

            var user = UserSession.CurrentUser;
            string newPassword = NewPasswordField.Text;
            string confirmPassword = ConfirmPasswordField.Text;

            if (!UserService.ChangePassword(user, newPassword, confirmPassword, out string error))
            {
                this.errorLabel.Text = error;
                return;
            }

            MessageBox.Show("Password changed successfully.");
            this.Close();
        }

        private void BackToHomepage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
