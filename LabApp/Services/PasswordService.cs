namespace LabApp
{
    internal static class PasswordService
    {
        public static string HashPassword(string password)
        {
            return password;
        }


        public static bool VerifyPassword(string password, string storedPassword)
        {
            return password == storedPassword;
        }
    }
}