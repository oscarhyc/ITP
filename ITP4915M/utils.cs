using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ITP4915M
{
    class utils
    {
        public static string hashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encryted_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encryted_bytes);
        }

        public static string HashString(string passwordString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(passwordString))
                sb.Append(b.ToString("X3"));
            return sb.ToString();
        }

        public static byte[] GetHash(string passwordString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordString));
        }
    }
}
