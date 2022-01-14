using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.EmployeeClasses
{
    class ContractEmployee : MyEmployee
    {
        #region Properties
        public double DailyRate { get; set; } = 0.0;
        #endregion

        #region Methods
        public ContractEmployee()
            : this(Globals.UNKNOWN, Globals.UNKNOWN, 0.0d)
        {

        }

        public ContractEmployee(string firstName, string lastName, double dailyRate)
            : base(firstName, lastName)
        {
            DailyRate = dailyRate;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Daily Rate: {DailyRate:0.00}";
        }

        public override double CalculateHourlyRate()
        {
            return DailyRate / 8.0;
        }
        #endregion
    }
}
