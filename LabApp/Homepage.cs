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
    public partial class Homepage : Form
    {
        public bool IsLogout { get; private set; } = false;
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            if (UserSession.IsAuthenticated())
            {
                HelloUsername.Text = $"Welcome, {UserSession.CurrentUser.Username}!";
            }
            else
            {
                MessageBox.Show("Access denied. Please log in first.");
                this.Close();
            }
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            UserSession.Logout();
            IsLogout = true;
            this.Close();
        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword
            {
                Owner = this
            };
            changePassword.FormClosed += ChangePassword_FormClosed;
            changePassword.Show();

            this.Enabled = false;
        }
        private void ChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true; 
            this.BringToFront(); 
        }
    }
}
