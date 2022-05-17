using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UserDB
{
    class HashPassword
    {
        public static string ComputeHash(string Password, string Salt)
        {
            //https://www.thatsoftwaredude.com/content/6218/how-to-encrypt-passwords-using-sha-256-in-c-and-net

            string sPassword = Password + Salt;
            SHA256 sha256 = SHA256Managed.Create();
            UTF8Encoding objUtf8 = new UTF8Encoding();
            byte[] hashValue = sha256.ComputeHash(objUtf8.GetBytes(sPassword));

            return Convert.ToBase64String(hashValue);
        }


        //https://www.geeksforgeeks.org/c-sharp-randomly-generating-strings/
        public static string CreateSalt(int stringlen)
        {
            Random res = new Random();

            // String that contain both alphabets and numbers
            String str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Initializing the empty string
            String randomstring = "";

            for (int i = 0; i < stringlen; i++)
            {

                // Selecting a index randomly
                int x = res.Next(str.Length);

                // Appending the character at the 
                // index to the random alphanumeric string.
                randomstring = randomstring + str[x];
            }

            return randomstring;
        }
    }
}
