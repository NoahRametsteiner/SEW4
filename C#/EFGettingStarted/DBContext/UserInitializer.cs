using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFGettingStarted.Model;

namespace EFGettingStarted.DBContext
{
    class UserInitializer : DropCreateDatabaseAlways<EFContext>
    {
        protected override void Seed(EFContext context)
        {
            IList<User> defaultUsers = new List<User>();

            defaultUsers.Add(new User
            {
                Name = "Karl Arbei",
                Email = "karl@arbeit.com"
            });

            defaultUsers.Add(new User
            {
                Name = "Andi Arbei",
                Email = "andi@arbeit.com"
            });

            context.Users.AddRange(defaultUsers);

            base.Seed(context);
        }
    }
}
