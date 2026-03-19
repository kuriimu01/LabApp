using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabApp.TBD_But
{
    public static class ValidateUser
    {

        public static bool IsUsernameValid(string username, out string error) {
            error = "";
            if (string.IsNullOrWhiteSpace(username)) {
                error = "The username cannot be empty or contain spaces.";
                return false;
            }

            return true;
        }
        public static bool IsPasswordValid(string password, bool useStrongPassword, out string error) {
            error = "";
            if (string.IsNullOrEmpty(password)) {
                error = "The password cannot be empty.";
                return false;
            }
            if (!useStrongPassword) return true; 
            if (password.Length < 8) {
                error = "The password must be at least 8 characters long.";
                return false;
            }

            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecial = password.Any(ch => !char.IsLetterOrDigit(ch));

            int sets = 0;
            if (hasUpper || hasLower) sets++;
            if (hasDigit) sets++;
            if (hasSpecial) sets++;

            if (sets < 3)
            {
                error = "The password must contain at least three of the following:\n uppercase and lowercase letters, digits, special characters.";
                return false;
            }
            return true;
        }
    }
}
