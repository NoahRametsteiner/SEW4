using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WindowsFirewallHelper;
using MySql.Data.MySqlClient;

namespace WindowsFirewallHelper
{
    class Program
    {

        public static string login = @"server=localhost;userid=root;password=;database=passworddb";

        static void Main(string[] args)
        {
            // This Program Needs Root Privileges To Add To The Firewall
            
            var myRule = FirewallManager.Instance.Rules.SingleOrDefault(r => r.Name == "MyApp Rule");
            if (myRule != null)
            {
                FirewallManager.Instance.Rules.Remove(myRule);
            }
            else
            {
                var rule = FirewallManager.Instance.CreateApplicationRule(
                    @"MyApp Rule",
                    FirewallAction.Block,
                    @"C:\Users\Notsch\Downloads\BetterDiscord-Windows.exe"
                );
                rule.Direction = FirewallDirection.Outbound;
                FirewallManager.Instance.Rules.Add(rule);
            }
        }
    }
}
