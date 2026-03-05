using System;
using System.Security.Cryptography;

namespace LabApp
{
    internal static class PasswordHelper
    {
        private const int SaltSize = 16; // 128 bit
        private const int HashSize = 32; // 256 bit for SHA256
        private const int Iterations = 100_000; // Number of PBKDF2 iterations

        public static string HashPassword(string password)
        {
            // Generating a salt
            byte[] salt = new byte[SaltSize];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            // Generating the hash PBKDF2 with SHA256
            var pbkdf2 = new Rfc2898DeriveBytes(
                password, 
                salt, 
                Iterations, 
                HashAlgorithmName.SHA256);

            byte[] hash = pbkdf2.GetBytes(HashSize);

            // Combining salt and hash
            byte[] hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            // Converting to Base64 string
            return Convert.ToBase64String(hashBytes);
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Converting Base64 string back to byte array
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);

            // Extracting the salt
            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            // Extracting the hash
            byte[] hash = new byte[HashSize];
            Array.Copy(hashBytes, SaltSize, hash, 0, HashSize);

            // Generating the hash for the provided password with same salt
            var pbkdf2 = new Rfc2898DeriveBytes(
                password, 
                salt, 
                Iterations, 
                HashAlgorithmName.SHA256);
            byte[] HashToCompare = pbkdf2.GetBytes(HashSize);

            // Comparing the hashes byte by byte
            for (int i = 0; i < HashSize; i++) {
                if (hash[i] != HashToCompare[i]) {
                    return false;
                }
            }
            
            return true;
        }
    }
}
