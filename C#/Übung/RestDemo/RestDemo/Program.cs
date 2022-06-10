using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myRestClient = new MyRestClient();
            myRestClient.BaseURL = "https://reqres.in/";
            myRestClient.GetSingleUser(1);
            myRestClient.GetAllUser(1);

            Console.ReadKey();
        }
    }
}
