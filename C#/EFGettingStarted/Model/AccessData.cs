using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFGettingStarted.Model
{
    public class AccessData // n
    {
        public int Id { get; set; }
        public String LoginName { get; set; } = string.Empty;
        public String Password { get; set; } = string.Empty;

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
