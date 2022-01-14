using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class City
    {

        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Population { get; set; }

        public static IList<City> Factory()
        {
            IList<City> cityList = new List<City>();

            #region dummy
            cityList.Add(new City { Id = 1, Name = "London", Population = 1900000 });
            cityList.Add(new City { Id = 2, Name = "London", Population = 9000000 });
            cityList.Add(new City { Id = 3, Name = "London", Population = 2100000 });
            #endregion

            return cityList;

        }


    }
}
