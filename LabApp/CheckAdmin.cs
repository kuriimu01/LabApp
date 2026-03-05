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
    public partial class CheckAdmin : Form
    {
        public bool IsAuthorized { get; private set; } = false;

        public CheckAdmin()
        {
            InitializeComponent();
        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            if (IsAdminPasswordCorrect(this.PassAdminField.Text))
            {
                IsAuthorized = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect admin password. Access denied.");
            }
        }


        private bool IsAdminPasswordCorrect(string password)
        {
            const string adminPassword = "SuperSecret123";
            return password == adminPassword;
        }
    }
}
