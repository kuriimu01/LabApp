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
    }
    public enum UserRole
    {
        Administrator = 1,
        Manager = 2,
        Guest = 3,
        Tester = 4
    }
}
