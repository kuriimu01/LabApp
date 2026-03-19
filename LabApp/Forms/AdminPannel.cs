using LabApp.Models;
using LabApp.Security;
using LabApp.Services;
using LabApp.TBD_But;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LabApp
{
    public partial class AdminPannel : Form
    {
        public AdminPannel()
        {
            InitializeComponent();
        }

        private void AdminPannel_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            rolesData.Visible = false;
            AddRoleAccessRule.Visible = false;
            SaveRoleAccessRule.Visible = false;
            DelRoleAccessRule.Visible = false;

            disData.Visible = false;
            disAdd.Visible = false;
            disSave.Visible = false;
            disDel.Visible = false;

            if (SecuritySettings.CurrentModel == AccessModel.RoleBased)
            {
                rolesData.Visible = true;
                AddRoleAccessRule.Visible = true;
                SaveRoleAccessRule.Visible = true;
                DelRoleAccessRule.Visible = true;
                LoadRules();
            }
            else if (SecuritySettings.CurrentModel == AccessModel.Discretionary)
            {
                disData.Visible = true;
                disAdd.Visible = true;
                disSave.Visible = true;
                disDel.Visible = true;
                LoadRules();
            }

            LoadUsers();
            LoadResources();
            ConfigureViewForCurrentModel();
        }

        private void LoadUsers()
        {
            var users = DbDataAccess.LoadUsers();
            usersData.DataSource = users;

            GridService.SetupSecurityLevelColumn(usersData);
            GridService.SetupCheckBoxColumn(usersData, "UseStrongPassword", "Strong Password");
            GridService.SetupCheckBoxColumn(usersData, "IsAdmin", "Is Admin");

            usersData.Columns["PasswordHash"].Visible = false;
            usersData.Columns["Id"].ReadOnly = true;
            ConfigureViewForCurrentModel();
        }

        private void LoadRules()
        {
            var allResources = DbDataAccess.LoadResources();

            if (SecuritySettings.CurrentModel == AccessModel.RoleBased)
            {
                var rolesRules = DbDataAccess.LoadRoleAccessRules();
                rolesData.DataSource = new BindingList<RoleAccessRule>(rolesRules);

                var allRoles = DbDataAccess.LoadRoles();
                GridService.SetupComboBoxColumn(rolesData, "RoleId", "Role", allRoles, "Name", "Id");
                GridService.SetupComboBoxColumn(rolesData, "ResourceId", "Resource", allResources, "FileName", "Id");
                GridService.SetupCheckBoxColumn(rolesData, "CanRead", "Read");
                GridService.SetupCheckBoxColumn(rolesData, "CanWrite", "Write");
                GridService.SetupCheckBoxColumn(rolesData, "CanExecute", "Execute");

                if (rolesData.Columns.Contains("TimeStart")) rolesData.Columns["TimeStart"].Visible = true;
                if (rolesData.Columns.Contains("TimeEnd")) rolesData.Columns["TimeEnd"].Visible = true;
                if (rolesData.Columns.Contains("IpRestrict")) rolesData.Columns["IpRestrict"].Visible = true;

                rolesData.Columns["Id"].ReadOnly = true;

                if (rolesData.Columns.Contains("Id")) rolesData.Columns["Id"].DisplayIndex = 0;
                if (rolesData.Columns.Contains("RoleId")) rolesData.Columns["RoleId"].DisplayIndex = 1;
                if (rolesData.Columns.Contains("ResourceId")) rolesData.Columns["ResourceId"].DisplayIndex = 2;
                if (rolesData.Columns.Contains("CanRead")) rolesData.Columns["CanRead"].DisplayIndex = 3;
                if (rolesData.Columns.Contains("CanWrite")) rolesData.Columns["CanWrite"].DisplayIndex = 4;
                if (rolesData.Columns.Contains("CanExecute")) rolesData.Columns["CanExecute"].DisplayIndex = 5;
                if (rolesData.Columns.Contains("TimeStart")) rolesData.Columns["TimeStart"].DisplayIndex = 6;
                if (rolesData.Columns.Contains("TimeEnd")) rolesData.Columns["TimeEnd"].DisplayIndex = 7;
                if (rolesData.Columns.Contains("IpRestrict")) rolesData.Columns["IpRestrict"].DisplayIndex = 8;

                rolesData.ScrollBars = ScrollBars.Both;
                rolesData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else if (SecuritySettings.CurrentModel == AccessModel.Discretionary)
            {
                var accessRules = DbDataAccess.LoadAccessRules();
                disData.DataSource = new BindingList<AccessRule>(accessRules);

                var allUsers = DbDataAccess.LoadUsers();
                GridService.SetupComboBoxColumn(disData, "UserId", "User", allUsers, "Username", "Id");
                GridService.SetupComboBoxColumn(disData, "ResourceId", "Resource", allResources, "FileName", "Id");
                GridService.SetupCheckBoxColumn(disData, "CanRead", "Read");
                GridService.SetupCheckBoxColumn(disData, "CanWrite", "Write");
                GridService.SetupCheckBoxColumn(disData, "CanExecute", "Execute");

                if (disData.Columns.Contains("TimeStart")) disData.Columns["TimeStart"].Visible = true;
                if (disData.Columns.Contains("TimeEnd")) disData.Columns["TimeEnd"].Visible = true;
                if (disData.Columns.Contains("IpRestrict")) disData.Columns["IpRestrict"].Visible = true;

                disData.Columns["Id"].ReadOnly = true;

                if (disData.Columns.Contains("Id")) disData.Columns["Id"].DisplayIndex = 0;
                if (disData.Columns.Contains("UserId")) disData.Columns["UserId"].DisplayIndex = 1;
                if (disData.Columns.Contains("ResourceId")) disData.Columns["ResourceId"].DisplayIndex = 2;
                if (disData.Columns.Contains("CanRead")) disData.Columns["CanRead"].DisplayIndex = 3;
                if (disData.Columns.Contains("CanWrite")) disData.Columns["CanWrite"].DisplayIndex = 4;
                if (disData.Columns.Contains("CanExecute")) disData.Columns["CanExecute"].DisplayIndex = 5;
                if (disData.Columns.Contains("TimeStart")) disData.Columns["TimeStart"].DisplayIndex = 6;
                if (disData.Columns.Contains("TimeEnd")) disData.Columns["TimeEnd"].DisplayIndex = 7;
                if (disData.Columns.Contains("IpRestrict")) disData.Columns["IpRestrict"].DisplayIndex = 8;

                disData.ScrollBars = ScrollBars.Both;
                disData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void LoadResources()
        {
            var resources = DbDataAccess.LoadResources();
            resourceData.DataSource = resources;

            GridService.SetupSecurityLevelColumn(resourceData);

            resourceData.Columns["Id"].ReadOnly = true;
            resourceData.Columns["FilePath"].Visible = false;
            ConfigureViewForCurrentModel();
        }

        private void ConfigureViewForCurrentModel()
        {
            if (SecuritySettings.CurrentModel != AccessModel.Mandatory)
            {
                if (usersData.Columns.Contains("SecurityLevel")) usersData.Columns["SecurityLevel"].Visible = false;
                if (resourceData.Columns.Contains("SecurityLevel")) resourceData.Columns["SecurityLevel"].Visible = false;
            }

            if (SecuritySettings.CurrentModel == AccessModel.RoleBased)
            {
                if (usersData.Columns.Contains("RoleId")) usersData.Columns["RoleId"].Visible = true;

                var allRoles = DbDataAccess.LoadRoles();
                GridService.SetupComboBoxColumn(usersData, "RoleId", "Role", allRoles, "Name", "Id");
            }
            else
            {
                if (usersData.Columns.Contains("RoleId")) usersData.Columns["RoleId"].Visible = false;
            }
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
            LoadResources();
        }

        private void deleteResource_Click(object sender, EventArgs e)
        {
            if (resourceData.CurrentRow == null) return;

            int id = (int)resourceData.CurrentRow.Cells["Id"].Value;
            DbDataAccess.DeleteResource(id);
            LoadResources();
        }

        private void AddRoleAccessRule_Click(object sender, EventArgs e)
        {
            var list = (BindingList<RoleAccessRule>)rolesData.DataSource;
            int nextId = list.Count > 0 ? list.Max(r => r.Id) + 1 : 1;
            list.Add(new RoleAccessRule { Id = nextId, RoleId = 1, ResourceId = 1 });
        }

        private void SaveRoleAccessRule_Click(object sender, EventArgs e)
        {
            var list = (BindingList<RoleAccessRule>)rolesData.DataSource;
            foreach (var rule in list)
            {
                DbDataAccess.SaveRoleAccessRule(rule);
            }
            MessageBox.Show("Changes saved successfully!");
        }

        private void DelRoleAccessRule_Click(object sender, EventArgs e)
        {
            if (rolesData.CurrentRow != null)
            {
                var rule = (RoleAccessRule)rolesData.CurrentRow.DataBoundItem;
                var list = (BindingList<RoleAccessRule>)rolesData.DataSource;
                list.Remove(rule);
                DbDataAccess.DeleteRoleAccessRule(rule.Id);
            }
        }

        private void disSave_Click_1(object sender, EventArgs e)
        {
            var list = (BindingList<AccessRule>)disData.DataSource;
            foreach (var rule in list)
            {
                DbDataAccess.SaveAccessRule(rule);
            }
            MessageBox.Show("Changes saved successfully!");
        }

        private void disAdd_Click_1(object sender, EventArgs e)
        {
            var list = (BindingList<AccessRule>)disData.DataSource;
            int nextId = list.Count > 0 ? list.Max(r => r.Id) + 1 : 1;
            list.Add(new AccessRule { Id = nextId, UserId = 1, ResourceId = 1 });
        }

        private void disDel_Click_1(object sender, EventArgs e)
        {
            if (disData.CurrentRow != null)
            {
                var rule = (AccessRule)disData.CurrentRow.DataBoundItem;
                var list = (BindingList<AccessRule>)disData.DataSource;
                list.Remove(rule);
                DbDataAccess.DeleteAccessRule(rule.Id);
            }
        }
    }
}