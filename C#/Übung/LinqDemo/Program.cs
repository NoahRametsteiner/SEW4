using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1; // Explizit Typisiert

            var z = 2; // Implizit Typisiert

            //Geht Nicht! Da Der Typ Bereits Festliegt
            //x = "yy";
            //z = "yy";

            // Nicht Typ Sicher:
            // JavaScript, PHP
            // Kann Zu Laugzeitfehlern Führen

            IList<string> names = new List<string>();
            names.Add("Mike Rohsoft");
            names.Add("Sergey Fährlich");
            names.Add("Karl Toffel");


            // LINQ Statement
            // Liste Wird Umsortiert, Ist Nur Ein View
            var sortedNames = from name in names
                where name.Length > 5
                orderby name descending
                select name;

            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }
             
            // Lambda Expression
            var sortedNames2 = names.Where(n => n.Length < 5).OrderByDescending(n => n);

            foreach (var name in sortedNames2)
            {
                Console.WriteLine(name);
            }



            var sortedPerson2 = Person.Factory()
                .Where(p => p.FirstName.StartsWith("A"))
                .OrderByDescending(p => p.LastName)
                .ThenBy(p => p.FirstName);
            //.Select(p => p); Optional, Nicht Unbedingt Erforderlich


            //Data Transformation
            var personStatistic = Person.Factory().GroupBy(p => p.Age). //Gruppiert nach alter
                OrderBy(g => g.Key);
                // Select(new PersonenStatistics
                // {
                //     Age = g.Key,
                //     Number = g.Count(),
                // });

            //No Results
            var noResult1 = Person.Factory().
                Where(p => p.FirstName == "Bill" && p.LastName == "Yard")
                .FirstOrDefault();
            if (noResult1 == default(Person))
                Console.WriteLine("Keine Daten Gefunden!");

            //Gruppireung LINQ

            var groupedPerson = from p in Person.Factory()
                group p by p.Age
                into personGroup
                orderby personGroup.Key //Gruppiert Über Alter Und Sortiert Anschließend
                select personGroup;

            // Ausgabe
            OutputGroup(groupedPerson);


            //Gruppierung LAMBA Expression

            var goupedPersons2 = Person.Factory()
                .GroupBy(p => p.Age)
                .OrderBy(g => g.Key);

            // Ausgabe
            OutputGroup(goupedPersons2);


            //Joins
            var joinedQuery = from p in Person.Factory()
                join c in City.Factory() on p.City equals c.Id
                where c.Population > 100000
                select p;

            var joinedQuery2 = Person.Factory().Join(City.Factory().Where(c => c.Population > 100000),
                p => p.City,c => c.Id, (p, c) => (p , c));

            //Ausgabe
            joinedQuery2.ToList().ForEach(x => Console.WriteLine($"City: {x.c.Id}; Person {x.p.FirstName}"));





        }


        //DRY (Dont Reapet Yourself)
        private static void OutputGroup(IEnumerable<IGrouping<int, Person>> groupedPerson)
        {
            foreach (var personGroup in groupedPerson)
            {
                Console.WriteLine($"Alter {personGroup.Key} Anzahl {personGroup.Count()}");

                foreach (var person in personGroup)
                {
                    Console.WriteLine($"{person.FirstName}");
                }
            }
        }

    }
}   
