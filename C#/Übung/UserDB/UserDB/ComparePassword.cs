using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UserDB
{
    class ComparePassword
    {
        public static bool PasswordCompare(string DBLogin, string Email, string EnterdPassword)
        {

            var Connection1 = new MySqlConnection(DBLogin);
            Connection1.Open();
            var sqlstatment = $"select * from user where email=\"{Email}\"";
            var getemail = new MySqlCommand(sqlstatment, Connection1);
            MySqlDataReader reader = getemail.ExecuteReader();

            if (reader.Read())
            {
                string HashedEnterdPassword = HashPassword.ComputeHash(EnterdPassword, (string)reader["salt"]);

                //Console.WriteLine($"HashedEnterdPassword: {HashedEnterdPassword} DBPassword: {(string)reader["password"]}");

                if (String.Equals(HashedEnterdPassword, (string)reader["password"]))
                {
                    Console.WriteLine("True");
                    return true;
                }
            }
            Console.WriteLine("False");
            return false;
        }
    }
}
