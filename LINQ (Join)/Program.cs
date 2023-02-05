using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ__Join_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<EmployeeID>();
            employees.Add(new EmployeeID { ID = "111", Name = "Ivanov Ivan" });
            employees.Add(new EmployeeID { ID = "222", Name = "Denisov Denis" });
            employees.Add(new EmployeeID { ID = "333", Name = "Artemov Artem" });
            employees.Add(new EmployeeID { ID = "333", Name = "Andreev Andrey" });
            employees.Add(new EmployeeID { ID = "444", Name = "Sergeev Sergey" });

            var empNationalities = new List<EmployeeNationality>()
            {
                new EmployeeNationality { ID = "111",Nationality="Russian"},
                new EmployeeNationality { ID = "222",Nationality="Ukraine"},
                new EmployeeNationality { ID = "333",Nationality="American"},
                new EmployeeNationality { ID = "444",Nationality="Armenia"},

            };


            var result = from e in employees
                         join n in empNationalities // обьединяем
                         on e.ID equals n.ID        // по ID
                         orderby n.Nationality descending
                         select new
                         {
                             ID = e.ID,
                             Name = e.Name,
                             Nacionality = n.Nationality
                         };
            foreach (var item in result)
            {
                Console.WriteLine($"{item.ID} {item.Name} {item.Nacionality}");
            }
        }
    }
   public class EmployeeID
    {
        public string ID { get; set; }
        public string  Name { get; set; }
    }
   public class EmployeeNationality
    {
        public string ID { get; set; }
        public string Nationality { get; set; }
    }
}
