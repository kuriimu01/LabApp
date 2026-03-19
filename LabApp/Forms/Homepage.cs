using LabApp.Security;
using LabApp.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LabApp.TBD_But;
using System.Net;
using System.Net.Sockets;

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
            if (UserSession.IsAuthenticated)
            {
                HelloUsername.Text = $"Welcome, {UserSession.CurrentUser.Username}!";

                if (SecuritySettings.CurrentModel == AccessModel.RoleBased)
                {
                    RoleLabel.Visible = true;
                    RoleLabel.Text = $"Role: {UserSession.Role}";
                }
                else if (SecuritySettings.CurrentModel == AccessModel.Discretionary)
                {
                    RoleLabel.Visible = true;
                    RoleLabel.Text = $"IP: {GetLocalIpAddress()}";
                }
                else
                {
                    RoleLabel.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Access denied. Please log in first.");
                this.Close();
            }
            LoadResources();
        }

        private string GetLocalIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void LoadResources()
        {
            var allResources = DbDataAccess.LoadResources();
            var user = UserSession.CurrentUser;

            var allowedResources = new List<ResourceModel>();
            var accessMap = new Dictionary<int, Tuple<bool, bool, bool>>();

            foreach (var res in allResources)
            {
                bool r = AccessManager.CheckAccess(user, res, "read");
                bool w = AccessManager.CheckAccess(user, res, "write");
                bool x = AccessManager.CheckAccess(user, res, "execute");

                if (r || w || x)
                {
                    allowedResources.Add(res);
                    accessMap[res.Id] = new Tuple<bool, bool, bool>(r, w, x);
                }
            }

            resourceData.DataSource = allowedResources;

            GridService.SetupSecurityLevelColumn(resourceData);

            resourceData.Columns["Id"].ReadOnly = true;
            resourceData.Columns["FilePath"].Visible = false;
            resourceData.Columns["SecurityLevel"].Visible = SecuritySettings.CurrentModel == AccessModel.Mandatory;

            GridService.SetupCheckBoxColumn(resourceData, "CanRead", "Read");
            GridService.SetupCheckBoxColumn(resourceData, "CanWrite", "Write");
            GridService.SetupCheckBoxColumn(resourceData, "CanExecute", "Execute");

            resourceData.Columns["CanRead"].ReadOnly = true;
            resourceData.Columns["CanWrite"].ReadOnly = true;
            resourceData.Columns["CanExecute"].ReadOnly = true;

            if (SecuritySettings.CurrentModel == AccessModel.Discretionary)
            {
                if (!resourceData.Columns.Contains("TimeStart")) resourceData.Columns.Add("TimeStart", "Time Start");
                if (!resourceData.Columns.Contains("TimeEnd")) resourceData.Columns.Add("TimeEnd", "Time End");
                if (!resourceData.Columns.Contains("IpRestrict")) resourceData.Columns.Add("IpRestrict", "IP Restrict");

                resourceData.Columns["TimeStart"].ReadOnly = true;
                resourceData.Columns["TimeEnd"].ReadOnly = true;
                resourceData.Columns["IpRestrict"].ReadOnly = true;

                var accessRules = DbDataAccess.LoadAccessRules().Where(r => r.UserId == user.Id).ToList();

                for (int i = 0; i < allowedResources.Count; i++)
                {
                    var res = allowedResources[i];
                    var rule = accessRules.FirstOrDefault(r => r.ResourceId == res.Id);

                    resourceData.Rows[i].Cells["CanRead"].Value = accessMap[res.Id].Item1 ? 1 : 0;
                    resourceData.Rows[i].Cells["CanWrite"].Value = accessMap[res.Id].Item2 ? 1 : 0;
                    resourceData.Rows[i].Cells["CanExecute"].Value = accessMap[res.Id].Item3 ? 1 : 0;

                    if (rule != null)
                    {
                        resourceData.Rows[i].Cells["TimeStart"].Value = rule.TimeStart;
                        resourceData.Rows[i].Cells["TimeEnd"].Value = rule.TimeEnd;
                        resourceData.Rows[i].Cells["IpRestrict"].Value = rule.IpRestrict;
                    }
                }
            }
            else
            {
                if (resourceData.Columns.Contains("TimeStart")) resourceData.Columns.Remove("TimeStart");
                if (resourceData.Columns.Contains("TimeEnd")) resourceData.Columns.Remove("TimeEnd");
                if (resourceData.Columns.Contains("IpRestrict")) resourceData.Columns.Remove("IpRestrict");

                for (int i = 0; i < allowedResources.Count; i++)
                {
                    var res = allowedResources[i];
                    resourceData.Rows[i].Cells["CanRead"].Value = accessMap[res.Id].Item1 ? 1 : 0;
                    resourceData.Rows[i].Cells["CanWrite"].Value = accessMap[res.Id].Item2 ? 1 : 0;
                    resourceData.Rows[i].Cells["CanExecute"].Value = accessMap[res.Id].Item3 ? 1 : 0;
                }
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
            changePassword.ShowDialog();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (resourceData.CurrentRow == null) return;

            var resource = resourceData.CurrentRow.DataBoundItem as ResourceModel;
            if (resource == null) return;

            var user = UserSession.CurrentUser;

            try
            {
                FileService.Open(user, resource);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadResources();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadResources();
        }
    }
}