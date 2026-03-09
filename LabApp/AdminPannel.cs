using LabApp.TBD_But;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabApp
{
    public partial class AdminPannel : Form
    {
        public AdminPannel()
        {
            InitializeComponent();
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in usersData.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.DataBoundItem is UserModel user)
                {
                    DbDataAccess.UpdateUser(user);
                }
            }

            MessageBox.Show("Changes saved successfully!");
            LoadUsers();
        }

        private void AdminPannel_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadResources();
        }

        private void LoadUsers()
        {
            var users = DbDataAccess.LoadUsers();
            usersData.DataSource = users;

            GridHelpers.SetupSecurityLevelColumn(usersData);

            usersData.Columns["PasswordHash"].Visible = false;
            usersData.Columns["Id"].ReadOnly = true;
        }
        private void LoadResources()
        {
            var resources = DbDataAccess.LoadResources();
            resourceData.DataSource = resources;

            GridHelpers.SetupSecurityLevelColumn(resourceData);

            resourceData.Columns["Id"].ReadOnly = true;
            resourceData.Columns["FilePath"].Visible = false;
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (usersData.CurrentRow == null) return;

            int id = (int)usersData.CurrentRow.Cells["Id"].Value;

            DbDataAccess.DeleteUser(id);

            LoadUsers();
        }

        private void addResource_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select a resource file";
                ofd.Filter = "All files (*.*)|*.*";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fullPath = ofd.FileName;
                    string fileName = Path.GetFileName(fullPath);

                    ResourceModel newResource = new ResourceModel()
                    {
                        FileName = fileName,
                        FilePath = fullPath,
                        SecurityLevel = (int)SecurityLevel.NotSecret
                    };

                    DbDataAccess.AddResource(newResource);

                    LoadResources();
                }
            }
        }

        private void saveResource_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in resourceData.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.DataBoundItem is ResourceModel resource)
                {
                    DbDataAccess.UpdateResource(resource);
                }
            }

            MessageBox.Show("Changes saved successfully!");
            LoadUsers();
        }

        private void deleteResource_Click(object sender, EventArgs e)
        {
            if (resourceData.CurrentRow == null) return;

            int id = (int)resourceData.CurrentRow.Cells["Id"].Value;

            DbDataAccess.DeleteResource(id);

            LoadResources();
        }
    }
}
