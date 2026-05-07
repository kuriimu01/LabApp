using System;
using System.Security.Cryptography;
using System.Text;

namespace LabApp
{
    public static class PasswordService
    {
        // Хешуємо пароль алгоритмом SHA-256
        public static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                // Перетворюємо рядок пароля в масив байтів
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Конвертуємо байти у шістнадцятковий рядок (hex string)
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            // Для перевірки просто хешуємо введене значення і порівнюємо з тим, що в БД
            string hashOfInput = HashPassword(password);
            return hashOfInput == storedHash;
        }
    }
}