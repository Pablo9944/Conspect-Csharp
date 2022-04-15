using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_Struct
{
   public struct Worker
    {
        public string position;
        public uint salary;
        public string Firstname;
        public string Lastname;
        public DateTime DateOfBirth;

        public string Print()
        {
            return $"Должность {position} Зарплата {salary} Имя {Firstname} Фамилия {Lastname} Дата рождения {DateOfBirth.ToShortDateString()}";
        }
        public Worker(string position, uint salary, string Firstname, string Lastname, DateTime DateOfBirth)
        {
            this.position = position;
            this.salary = salary;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.DateOfBirth = DateOfBirth;
        }

        public Worker(string position, uint salary, string Firstname, string Lastname):this (position, salary, Firstname, Lastname,new DateTime(1990,1,1))
        {
            
            

        }
        public Worker(string position, uint salary, string Firstname) : this(position, salary, Firstname, String.Empty, new DateTime(1990, 1, 1))
        {
            
            

        }

        public Worker(string position, uint salary) : this(position, salary, String.Empty, String.Empty, new DateTime(1990, 1, 1))
        {
            
            

        }
        public Worker(string position) : this(position, 0, String.Empty, String.Empty, new DateTime(1990, 1, 1))
        {
            
        }
        
    }
}
    