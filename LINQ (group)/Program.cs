using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ__group_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var query = from x in numbers
                        group x by x % 3;

            foreach (var group in query)
            {
                Console.WriteLine("mod{0} = {0}",group.Key);

                foreach (var number in group)
                {
                    Console.WriteLine("{0}",number);
                }
            }
            Console.WriteLine(new string('-',30));

            var employees = new List<Employee>
            {
                new Employee{FirstName = "Ivan",LastName="Ivanov",Nacional="Russia"},
                new Employee{FirstName = "Andrey",LastName="Andreev",Nacional="Ukraine"},
                new Employee{FirstName = "Fedr",LastName="Ferdrov",Nacional="American"},
                new Employee{FirstName = "Alex",LastName="Ivanov",Nacional="Russia"},
                new Employee{FirstName = "Ivan",LastName="Ivanov",Nacional="Russia"},
                new Employee{FirstName = "Andrey",LastName="Andreev",Nacional="Ukraine"},
                new Employee{FirstName = "Ivan",LastName="Ivanov",Nacional="Russia"},
                new Employee{FirstName = "Alex",LastName="Ivanov",Nacional="Russia"},
            };

            var query2 = from emp in employees
                         group emp by new
                         {
                             LastName = emp.LastName,
                             Nacional = emp.Nacional
                         };

            foreach (var group in query2)
            {
                Console.WriteLine($"group {group.Key}");
                foreach (var emp in group)
                {
                    Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.Nacional}");
                }
            }


        }
    }
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nacional { get; set; }
    }
}
