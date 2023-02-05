using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>()
            {
              new Employee
              {   FirstName = "Vladimir",
                LastName="Dylev",
                Salary=80000,
                StartDate = DateTime.Parse("24/8/2000")},

              new Employee
              {   FirstName = "Anna",
                LastName="Ivanova",
                Salary=99000,
                StartDate = DateTime.Parse("1/4/1992")
               },

              new Employee
              {   FirstName = "Boris",
                LastName="Britva",
                Salary=90000,
                StartDate = DateTime.Parse("5/7/1990")
              }

            };
            #region
            var result = employees
                        .Where(emp => emp.Salary < 95000)
                        .OrderBy(emp => emp.FirstName)
                        .OrderBy(emp => emp.LastName)
                        .Select(emp => new
                        {
                            FirstName = emp.FirstName,
                            LastName = emp.LastName
                        });

            foreach (var item in result)
            {
                Console.WriteLine(string.Format("{0} {1}", item.FirstName,item.LastName));
            }
            Console.WriteLine(new String('-',30));

            Console.WriteLine(result.GetType());


            #endregion

            #region
            var first = Enumerable.Range(1, 9);
            var second = Enumerable.Range(1, 10);

            var resultTable = from x in first
                              from y in second
                              select new
                              {
                                 X = x,
                                 Y = y,
                                 Product = x * y
                              };
      
            foreach (var item in resultTable)
            {
                Console.WriteLine($"{item.X} * {item.Y} = {item.Product}");
                
            }
            
            #endregion

        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
    }
    class Result
    {
        public string FirstName;
        public string LastName;
        public Result res;
        public Result(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            res = this;
        }
    }
}
