using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _666.Тестовая
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                var department = GetCurrentDepartment();


            }

        }

        static Department GetCurrentDepartment()
        {
            Department department = new Department();
            department.Company = department.Company ?? new Company();
            department.City = department.City ?? new City();
            department.Company.Name = null;



            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
                department.Company.Name = department?.Company?.Name ?? "Неизвестная компания";
                Console.WriteLine(department.Company.Name);
            }
            return department;


        }

    }


    class Company
    {
        public string Type = "Банк";
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;


    }

    class City
    {
        public string Name = "Санкт-Петербург";
    }



}
