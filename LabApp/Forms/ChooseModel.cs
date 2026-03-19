using LabApp.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LabApp.Security.SecuritySettings;

namespace LabApp.Forms
{
    public partial class ChooseModel : Form
    {
        public ChooseModel()
        {
            InitializeComponent();
        }

        private void ChooseModel_Load(object sender, EventArgs e)
        {
            ModelCombo.DataSource = Enum.GetValues(typeof(AccessModel));
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (ModelCombo.SelectedItem != null)
            {
                CurrentModel = (AccessModel)ModelCombo.SelectedItem;
                Login loginForm = new Login();
                loginForm.Show();

                this.Hide();
                loginForm.FormClosed += (s, ec) => this.Close();
            }
        }
    }
}
