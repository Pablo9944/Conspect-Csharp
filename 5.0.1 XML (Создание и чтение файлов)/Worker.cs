using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0._1_XML__Создание_и_чтение_файлов_
{
    public struct Worker
    {

        public string FirstName { get { return this.FirstName; } set { FirstName = value; } }
        public string LastName { get { return this.LastName; } set { this.LastName = value; } }
        public string Position { get { return this.Position; } set { this.Position = value; } }
        public uint Salary { get { return this.Salary; } set { this.Salary = value; } }
        public string Departament { get { return this.Departament; } set { this.Departament = value; } }



        public Worker(string FirstName, string LastName, string Position, uint Salary, string Departament)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Position = Position;
            this.Salary = Salary;
            this.Departament = Departament;

        }

        public string Print()
        {
            return ($"{this.FirstName,15} {this.LastName,15} {this.Position,15} {this.Salary,15} {this.Departament,15}");
        }


    }


}

