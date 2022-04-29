using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _666.Тестовая
{
    internal class Operator
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Departmert { get; set; }
        public uint Salary { get; set; }


        public Operator(string Name, string LastName,uint Salary, string Departmert)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Salary = Salary;   
            this.Departmert = Departmert;
        }
    
    
    
        public string Print()
        {
            return ($"{Name}\t {LastName}\t {Departmert}\t {Salary}");
        }
    }
}
