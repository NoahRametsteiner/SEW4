using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.EmployeeClasses
{
    class TemporaryEmployee : MyEmployee
    {
        #region Properties
        public double HourlyRate { get; set; } = 0.0;
        #endregion

        #region Methods
        public TemporaryEmployee()
            : this(Globals.UNKNOWN, Globals.UNKNOWN, 0.0d)
        {

        }

        public TemporaryEmployee(string firstName, string lastName, double hourlyRate)
            : base(firstName, lastName)
        {
            HourlyRate = hourlyRate;
        }
        public override string ToString()
        {
            return $"{base.ToString()} HourlyRate: {HourlyRate:0.00}";
        }

        public override double CalculateHourlyRate()
        {
            return HourlyRate;
        }
        #endregion
    }
}
