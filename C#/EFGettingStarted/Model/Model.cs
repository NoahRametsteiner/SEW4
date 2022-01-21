using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFGettingStarted.DBContext;

namespace EFGettingStarted.Model
{
    public class User //Class = Tabelles,, Properties = Rows => ORM Object Relation Mapping
    {
        public int UserID { get; set; } // Creates Property With ID
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
