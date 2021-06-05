
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    
        class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person { Name = "Van", Age = 10 },
                new Person { Name = "Andrey", Age = 25 },
                new Person { Name = "Viktor", Age = 3 },
                new Person { Name = "Viktor", Age = 19 },
                new Person { Name = "Ivan", Age = 19 },
                new Person { Name = "Sergey", Age = 5 },
                new Person { Name = "Artem", Age = 16 },
                new Person { Name = "Ivan", Age = 12 },
                new Person { Name = "Makar", Age = 5 },
                new Person { Name = "Vladislav", Age = 23 },
                new Person { Name = "Katerina", Age = 24 },
                new Person { Name = "Anna", Age = 5 },
                new Person { Name = "Svetlana", Age = 23 },
            };
            Console.WriteLine("TASK 1 Sort");
            var peopleSort = from p in people
                            orderby p.Age, p.Name
                            select p;
            foreach (Person p in peopleSort)
                Console.WriteLine("{0} {1}", p.Name, p.Age);
            Console.WriteLine("");

            Console.WriteLine("TASK 2 Old 20");
            var peopleOld20 = from p in people
                              where p.Age > 20
                              select p;
            foreach (Person p in peopleOld20)
                Console.WriteLine("{0} {1}", p.Name, p.Age);
            Console.WriteLine("");

            Console.WriteLine("TASK 3 Unique Name");
            var uniqueName = (from p in people
                              select p.Name).Distinct();
            foreach (string p in uniqueName)
                Console.WriteLine("{0}", p);
            Console.WriteLine("");

            Console.WriteLine("TASK 4 Grouping");
            var groupingNamePeople = from p in people
                                      orderby p.Age, p.Name
                                      group p by p.Age;
            foreach (var p in groupingNamePeople)
            {
                Console.WriteLine(p.Key);
                foreach (var n in p)
                    Console.WriteLine(n.Name);
            }
            Console.WriteLine("");

            Console.WriteLine("TASK 5");
            if (people.Any(p => p.Age >= 100))
            {
                var nowHundredPeople = from p in people
                                       where p.Age < 100
                                       select p;
                foreach (var p in nowHundredPeople)
                    Console.WriteLine($"{p.Name} {p.Age}");
                
            }
            Console.WriteLine("");

            Console.WriteLine("TASK 6");
            if (people.All(p => p.Age < 30))
            {
                var ivan = people.Find(p => p.Name == "Ivan");
                Console.WriteLine($"{ivan.Name} {ivan.Age}");
            }

            Console.ReadKey();
        }
    }
}
