using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Person
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public int Age { get; set; }
        public int City { get; set; }


        public static IList<Person> Factory()
        {
            IList<Person> personList = new List<Person>();

            #region dummy 
            personList.Add(new Person
            {
                FirstName = "Sue",
                LastName = "Pemarkt",
                Age = 20,
                City = 1,
            });

            personList.Add(new Person
            {
                FirstName = "Luci",
                LastName = "Fer",
                Age = 666,
                City = 2,
            });

            personList.Add(new Person
            {
                FirstName = "Andi",
                LastName = "Arbeit",
                Age = 29,
                City = 3,
            });

            personList.Add(new Person
            {
                FirstName = "Serge",
                LastName = "Fährlich",
                Age = 29,
                City = 1,
            });
            #endregion

            return personList;
        }
    }
}
