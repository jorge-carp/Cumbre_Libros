using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Cumbre_Libros
{
    internal class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(32);

            return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
        }

        public static bool VerifyPassword(string password, string storedHash, out string? upgradedHash)
        {
            upgradedHash = null;

            if (string.IsNullOrEmpty(storedHash))
                return false;

            var parts = storedHash.Split(':');

            // Case 1: Old plaintext password
            if (parts.Length != 2)
            {
                if (password == storedHash) // plaintext match
                {
                    // Upgrade hash immediately
                    upgradedHash = HashPassword(password);
                    return true;
                }
                return false;
            }

            var salt = Convert.FromBase64String(parts[0]);
            var storedHashBytes = Convert.FromBase64String(parts[1]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(32);

            return CryptographicOperations.FixedTimeEquals(hash, storedHashBytes);
        }
    }
}
