using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabApp.TBD_But
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int UseStrongPassword { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public int IsAdmin { get; set; }
        public int RoleId { get; set; }
        public DateTime PasswordChangedDate { get; set; } = DateTime.Now;
        public string OldPassword1 { get; set; } = "";
        public string OldPassword2 { get; set; } = "";
        public string OldPassword3 { get; set; } = "";
        public int FailedAttempts { get; set; } = 0;
        public DateTime? LockoutEnd { get; set; } = null;
    }
    public enum UserRole
    {
        Administrator = 1,
        Manager = 2,
        Guest = 3,
        Tester = 4
    }
}
