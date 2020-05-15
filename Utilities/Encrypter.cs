using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importing Libraries
using System.Configuration;
using System.Security.Cryptography;

namespace Astellas_Pharma.Utilities
{
    class Encrypter
    {
        public static string Encrypt(string text)
        {

            byte[] arrbyte = new byte[text.Length];
            SHA256 hash = new SHA256CryptoServiceProvider();
            arrbyte = hash.ComputeHash(Encoding.UTF8.GetBytes(text));
            return Convert.ToBase64String(arrbyte);
        }
    }
}
