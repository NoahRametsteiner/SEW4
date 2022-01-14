using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.EmployeeClasses
{
    public abstract class MyEmployee : IPayable
    {

        #region Properties
        // Property
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        // lesen = überall, schreiben = nur in der Klasse
        public string Tmp { get; private set; }

        // gilt nur in der Klasse, lesen + schreiben
        private string Tmp1 { get; set; }
        #endregion

        #region Methods
        public MyEmployee() : this(Globals.UNKNOWN, Globals.UNKNOWN)  // : Konstruktorverkettung
            // Reihenfolge: this Konstruktur, Employee() Konstruktor
        {
        }
        
        public MyEmployee(string firstName, string lastName )
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Das ist die Person {FirstName} {LastName}";
        }

        abstract public double CalculateHourlyRate();
        #endregion
    }
}
