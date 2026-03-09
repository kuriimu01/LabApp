using System;
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
            LoadResources();
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

        private void LoadResources()
        {
            var resources = DbDataAccess.LoadResources();
            resourceData.DataSource = resources;


            resourceData.Columns["Id"].ReadOnly = true;
            resourceData.Columns["FileName"].ReadOnly = true;
            resourceData.Columns["SecurityLevel"].ReadOnly = true;

            resourceData.Columns["FilePath"].Visible = false;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (resourceData.CurrentRow == null) return;

            var resource = resourceData.CurrentRow.DataBoundItem as ResourceModel;
            if (resource == null) return;

            var user = UserSession.CurrentUser;

            if ((int)user.SecurityLevel >= (int)resource.SecurityLevel)
            {
                MessageBox.Show($"Access granted to file: {resource.FileName}");
                System.Diagnostics.Process.Start(resource.FilePath);
            }
            else
            {
                MessageBox.Show($"Access denied! Your security level is too low.");
            }
        }
    }
}
