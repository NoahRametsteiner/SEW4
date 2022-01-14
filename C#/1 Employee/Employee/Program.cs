using Employee.EmployeeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.SyntaxElements();

            //new Program().SyntaxElements();

            // Teil 1
            // muss für Teil 3 auskommentiert werden, da Employee abstrakt wird
            //MyEmployee emp1 = new MyEmployee();
            //emp1.FirstName = "Hans";    // set Property
            //emp1.LastName = "Huber";
            //Console.WriteLine($"emp1: {emp1.FirstName} {emp1.LastName}");   // get Properties
            //MyEmployee emp2 = new MyEmployee("Barbara", "Schmidt");
            //Console.WriteLine($"emp2: {emp2.ToString()}");

            // Teil 2
            PermanentEmployee pe = new PermanentEmployee();
            ContractEmployee ce = new ContractEmployee("Hans", "Huber", 100.0);
            TemporaryEmployee te = new TemporaryEmployee("Barbara", "Schmidt", 7.5);
            Console.WriteLine(pe);
            Console.WriteLine(ce);
            Console.WriteLine(te);


            // Teil 3
            MyEmployee[] employees = new MyEmployee[3];
            employees[0] = new PermanentEmployee("Franz", "Schuster", 15000.0);
            employees[1] = new ContractEmployee("Hans", "Huber", 100.0);
            employees[2] = new TemporaryEmployee("Barbara", "Schmidt", 7.5);

            foreach (MyEmployee employee in employees)
                Console.WriteLine($"{employee} Hourly rate = {employee.CalculateHourlyRate():0.00}");

            // Teil 4
            IList<MyEmployee> employeeList = new List<MyEmployee>();
            employeeList.Add(new PermanentEmployee("Franz", "Schuster", 15000.0));
            employeeList.Add(new ContractEmployee("Hans", "Huber", 100.0));
            employeeList.Add(new TemporaryEmployee("Barbara", "Schmidt", 7.5));

            employeeList.ToList()
                .ForEach(e =>
                Console.WriteLine($"{e} Hourly rate = {e.CalculateHourlyRate():0.00}"));


            Console.ReadLine();
        }

        private void SyntaxElements()
        {
            int myInt = 1;
            string myString = "Ein Text";
            double myDouble = 233.34;

            Console.WriteLine("Eine Textausgabe\n");
            // $ = String Interpolation
            Console.WriteLine($"Integer: {myInt}");
            Console.WriteLine($"String: {myString}");
            Console.WriteLine($"Double: {myDouble:0.000}");

            string stringEinlesen = String.Empty;
            int intEinlesen = 0;

            //stringEinlesen = Console.ReadLine();
            // Exception fangen

            try
            {
                intEinlesen = Convert.ToInt32(stringEinlesen);
            } catch(FormatException)
            {
                Console.WriteLine("Falsches Eingabeformat");
                intEinlesen = 0;
            }
            // was passiert wenn xyz eingegeben wurde?
            // intEinlesen ausgeben

            Int32.TryParse(stringEinlesen, out intEinlesen);
            //Double.TryParse
            //Boolean.TryParse
            //float.TryParse

            Console.WriteLine($"Konvertierter Wert {intEinlesen}");

            if (myInt == 5)
                Console.WriteLine("myInt = 5");
            else
                Console.WriteLine("myInt != 5");

            // Arrays: fixe größe
            // resizing schwierig, neu anlegen + kopieren
            // -> Collections verwenden
            // z.B. List, Dictionary (Key, Value)

            // liste von strings
            IList<string> names = new List<string>();
            names.Add("Sue Permarkt");
            names.Add("Claas Scheibe");
            //names.Add(1); // Fehler
            names.Add("Karl Toffel");

            // for
            for(int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"for: Element an Position {i} = {names[i]}");
            }

            // while
            int x = 0;
            while (x < names.Count)
            {
                Console.WriteLine($"for: Element an Position {x} = {names[x]}");
                x++;
            }

            // foreach
            foreach (string name in names.Where(n => n.Length > 12).OrderBy(n => n))
                Console.WriteLine(name);

            names.Where(n => n.Length > 12)
                .OrderBy(n => n).ToList()
                .ForEach(Console.WriteLine);

            //          <> = Generics
            IDictionary<int, string> myDict = new Dictionary<int, string>();
            myDict.Add(3, "Mike Rhosoft");
            myDict.Add(2, "Andi Arbeit");
            myDict.Add(9, "Albert Tross");

            // löschen
            myDict.Remove(2);
            names.RemoveAt(1);

            foreach (/*KeyValuePair<int, string>*/ var entry in myDict)
                Console.WriteLine($"Key: {entry.Key} Value: {entry.Value}");

            Console.ReadKey();
        }
    }
}
