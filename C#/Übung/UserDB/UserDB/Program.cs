using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string DBLogin = @"server=localhost;userid=root;password=;database=passworddb";
            string Email = "testmail@gmail.com";
            string Password = "12345678";

            //AddUser.CreateUser(DBLogin,Email,Password);
            //AddUser.CreateUser(DBLogin, "testmail@gmail.com", "12345678");
            //AddUser.CreateUser(DBLogin, "testmail11123@gmail.com", "1234");

            ComparePassword.PasswordCompare(DBLogin, "testmail@gmail.com", "12345678");
            ComparePassword.PasswordCompare(DBLogin, "testmail11123@gmail.com", "1234");
            ComparePassword.PasswordCompare(DBLogin, "testmail11123@gmail.com", "12345678");

            Console.ReadLine();
        }
    }
}
