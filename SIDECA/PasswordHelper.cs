using System;
using System.Security.Cryptography;
using System.Text;

namespace SIDECA
{
    public static class PasswordHelper
    {
        public static string Encrypt(string pass)
        {
            using(var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(pass);
                var hashBytes = sha256.ComputeHash(bytes);

                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
