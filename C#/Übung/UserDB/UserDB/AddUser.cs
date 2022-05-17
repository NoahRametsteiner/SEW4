using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UserDB
{
    class AddUser
    {
        public static void CreateUser(string login,string email, string password)
        {
            //Var
            int UID = 0;
            string salt = HashPassword.CreateSalt(8);
           
            //Password To SHA256 Generator
            string hPassword = HashPassword.ComputeHash(password, salt);


            //https://www.codegrepper.com/code-examples/csharp/select+mysql+c%23
            //https://zetcode.com/csharp/mysql/
            //Login to DB And Get New UID
            var Connection1 = new MySqlConnection(login);
            Connection1.Open();
            var sqlstatment = "select * from user";
            var getuid = new MySqlCommand(sqlstatment, Connection1);
            MySqlDataReader reader = getuid.ExecuteReader();
            while (reader.Read()) { UID = (int)reader["uid"]; }
            UID++;
            Connection1.Close();

            //Login To DB And Add New User
            var Connection2 = new MySqlConnection(login);
            Connection2.Open();
            var cmd = new MySqlCommand();
            cmd.Connection = Connection2;

            cmd.CommandText = $"INSERT INTO user(uid, email,password,  salt) VALUES({UID},\"{email}\",\"{hPassword}\",\"{salt}\")";
            cmd.ExecuteNonQuery();
            Connection2.Close();
        }
    }
}
