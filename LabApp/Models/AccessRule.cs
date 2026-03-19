using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabApp.Security
{
    [Flags]
    public enum AccessRights
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }

    public class AccessRule
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ResourceId { get; set; }
        public int CanRead { get; set; }
        public int CanExecute { get; set; }
        public int CanWrite { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public string IpRestrict { get; set; }
    }
}