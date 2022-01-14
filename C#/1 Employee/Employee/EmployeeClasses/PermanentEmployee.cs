using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.EmployeeClasses
{
    class PermanentEmployee : MyEmployee
    {
        #region Properties
        public double Salary { get; set; } = 0.0;
        #endregion

        #region Methods
        public PermanentEmployee()
            : this(Globals.UNKNOWN, Globals.UNKNOWN, 0.0d)
        {

        }

        public PermanentEmployee(string firstName, string lastName, double salary)
            : base(firstName, lastName)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {Salary:0.00}";
        }

        public override double CalculateHourlyRate()
        {
            return Salary / 2000.0;
        }
        #endregion
    }
}
