using LabApp.TBD_But;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabApp.User
{
    public static class UserService
    {
        public static bool Authenticate(string username, string password, out UserModel user)
        {
            user = DbDataAccess.LoadUser(username);
            if (user == null) return false;
            return PasswordService.VerifyPassword(password, user.PasswordHash);
        }

        public static bool RegisterUser(string username, string password, bool strongPassword, bool isAdmin, out string error)
        {
            error = "";
            if (DbDataAccess.LoadUser(username) != null) { error = "User exists"; return false; }
            if (!ValidateUser.IsPasswordValid(password, strongPassword, out string passwordError)) { error = passwordError; return false; }

            UserModel newUser = new UserModel
            {
                Username = username,
                PasswordHash = PasswordService.HashPassword(password),
                UseStrongPassword = strongPassword ? 1 : 0,
                SecurityLevel = SecurityLevel.NotSecret,
                IsAdmin = isAdmin ? 1 : 0
            };
            DbDataAccess.SaveUser(newUser);
            return true;
        }

        public static bool ChangePassword(UserModel user, string newPassword, string confirmPassword, out string error)
        {
            error = "";
            if (newPassword != confirmPassword) { error = "Passwords do not match"; return false; }
            if (!ValidateUser.IsPasswordValid(newPassword, user.UseStrongPassword != 0, out string passwordError)) { error = passwordError; return false; }

            user.PasswordHash = PasswordService.HashPassword(newPassword);
            DbDataAccess.UpdateUser(user);
            return true;
        }
    }
}
