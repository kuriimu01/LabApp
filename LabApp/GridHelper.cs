using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabApp
{
    public static class GridHelpers
    {
        public static void SetupSecurityLevelColumn(DataGridView grid)
        {
            if (grid.Columns.Contains("SecurityLevel"))
                grid.Columns.Remove("SecurityLevel");

            DataGridViewComboBoxColumn securityColumn = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "SecurityLevel",
                HeaderText = "Security Level",
                Name = "SecurityLevel",
                DataSource = Enum.GetValues(typeof(SecurityLevel))
            };

            grid.Columns.Add(securityColumn);
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
