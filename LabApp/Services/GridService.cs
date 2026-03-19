using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabApp
{
    public static class GridService
    {
        public static void SetupSecurityLevelColumn(DataGridView grid)
        {
            if (grid.Columns["SecurityLevel"] != null)
                grid.Columns.Remove("SecurityLevel");

            var column = new DataGridViewComboBoxColumn
            {
                Name = "SecurityLevel",
                HeaderText = "Security Level",
                DataPropertyName = "SecurityLevel",
                DataSource = Enum.GetValues(typeof(SecurityLevel))
            };

            grid.Columns.Add(column);
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public static void SetupCheckBoxColumn(DataGridView grid, string columnName, string headerText)
        {
            if (grid.Columns.Contains(columnName) && !(grid.Columns[columnName] is DataGridViewCheckBoxColumn))
            {
                grid.Columns.Remove(columnName);
            }

            if (!grid.Columns.Contains(columnName))
            {
                var checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    Name = columnName,
                    HeaderText = headerText,
                    DataPropertyName = columnName,
                    TrueValue = 1,
                    FalseValue = 0
                };

                grid.Columns.Add(checkBoxColumn);
            }
        }
        public static void SetupComboBoxColumn(DataGridView grid, string columnName, string headerText, object dataSource, string displayMember, string valueMember)
            {
                if (grid.Columns.Contains(columnName) && !(grid.Columns[columnName] is DataGridViewComboBoxColumn))
                {
                    grid.Columns.Remove(columnName);

                    var comboColumn = new DataGridViewComboBoxColumn
                    {
                        Name = columnName,
                        HeaderText = headerText,
                        DataPropertyName = columnName,
                        DataSource = dataSource,
                        DisplayMember = displayMember,
                        ValueMember = valueMember,
                        DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                    };

                    grid.Columns.Add(comboColumn);
                }
            }
        }
    }
