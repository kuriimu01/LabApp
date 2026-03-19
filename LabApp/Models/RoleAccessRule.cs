using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabApp.Models
{
    public class RoleAccessRule
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ResourceId { get; set; }
        public int CanRead { get; set; }
        public int CanWrite { get; set; }
        public int CanExecute { get; set; }
    }
}
