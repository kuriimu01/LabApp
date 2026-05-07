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
        public static bool Authenticate(string username, string password, out UserModel user, out string error)
        {
            error = "";
            user = DbDataAccess.LoadUser(username);
            if (user == null) { error = "Користувача не знайдено."; return false; }

            // 1. Перевірка блокування
            if (user.LockoutEnd.HasValue && user.LockoutEnd.Value > DateTime.Now)
            {
                error = $"Акаунт заблоковано до {user.LockoutEnd.Value:HH:mm:ss}.";
                return false;
            }

            // 2. Перевірка правильності пароля та ліміт спроб
            if (!PasswordService.VerifyPassword(password, user.PasswordHash))
            {
                user.FailedAttempts++;
                if (user.FailedAttempts >= 3)
                {
                    user.LockoutEnd = DateTime.Now.AddMinutes(1); // Блокуємо на 1 хвилину
                    error = "3 невдалі спроби. Акаунт заблоковано на 5 хвилин.";
                }
                else
                {
                    error = $"Невірний пароль. Залишилось спроб: {3 - user.FailedAttempts}";
                }
                DbDataAccess.UpdateUser(user);
                return false;
            }

            // 3. Перевірка терміну дії пароля (30 днів)
            if ((DateTime.Now - user.PasswordChangedDate).TotalDays > 30)
            {
                error = "Термін дії пароля минув (більше 30 днів). Змініть пароль.";
                return false;
            }

            // Успішний вхід - скидаємо спроби
            if (user.FailedAttempts > 0 || user.LockoutEnd.HasValue)
            {
                user.FailedAttempts = 0;
                user.LockoutEnd = null;
                DbDataAccess.UpdateUser(user);
            }

            return true;
        }

        public static bool ChangePassword(UserModel user, string newPassword, string confirmPassword, out string error)
        {
            error = "";
            if (newPassword != confirmPassword) { error = "Паролі не співпадають"; return false; }
            if (!ValidateUser.IsPasswordValid(newPassword, user.UseStrongPassword != 0, out string passwordError)) { error = passwordError; return false; }

            string newHash = PasswordService.HashPassword(newPassword);

            // 4. Перевірка історії (3 останні паролі)
            if (newHash == user.PasswordHash || newHash == user.OldPassword1 || newHash == user.OldPassword2 || newHash == user.OldPassword3)
            {
                error = "Не можна використовувати поточний пароль або 3 попередні.";
                return false;
            }

            // Зсуваємо історію
            user.OldPassword3 = user.OldPassword2;
            user.OldPassword2 = user.OldPassword1;
            user.OldPassword1 = user.PasswordHash;

            user.PasswordHash = newHash;
            user.PasswordChangedDate = DateTime.Now;

            DbDataAccess.UpdateUser(user);
            return true;
        }
    }
}
