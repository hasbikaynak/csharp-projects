using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptiontext = "Mehmet1Kaynak";
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();

            byte[] encryptiontextbytes = System.Text.Encoding.UTF8.GetBytes(encryptiontext);
            byte[] MD5ComputeBytes = MD5.ComputeHash(encryptiontextbytes);
            string encryptedvalue = Convert.ToBase64String(MD5ComputeBytes);
            Console.WriteLine(encryptedvalue);
            Console.ReadKey();
        }
    }
}
