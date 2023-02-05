using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            
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

            #region Вариант 1 (LINQ)
            // переменная запроса
            var result = from employee in employees // from обьявляет переменную диапозона employee
                         where employee.Salary < 95000 // where - фильтр
                         orderby employee.FirstName, employee.LastName  // сортируем по возростанию
                         select new  // операция проекции
                         {
                             FirstName = employee.FirstName,  // критерии выборки
                             LastName = employee.LastName 
                         };
            
            foreach (var item in result)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);//+ " " + item.Salary);
            }
            Console.WriteLine(new string('#', 30));
            #endregion
         

            #region Вариант 2 (Лямбдой)
            //var result2 = employees.Where(e => e.FirstName.Length < 10).OrderBy(e => e.FirstName).Where(d => d.StartDate.Year < 2000).OrderBy(d => d.StartDate);
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(String.Format("{0} {1} {2} {3}", item.FirstName, item.LastName, item.Salary, item.StartDate));
            //}

            #endregion


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
}
