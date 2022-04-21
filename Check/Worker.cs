using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    struct  Worker
    {
        public string Position { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint Salary { get; set; }
        public string Department { get; set; }



        public Worker(string Position, string FirstName,string LastName,uint Salary,string Department)
        {
            this.Position = Position;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Salary = Salary;
            this.Department = Department;
        }
        public Worker(string Position, string FirstName, string LastName, uint Salary):this ( Position,  FirstName,  LastName,  Salary , string.Empty)
        {
            this.Department = "СВО";
        }
        public Worker(string Position, string FirstName, string LastName) : this(Position, FirstName, LastName, 0, string.Empty)
        {
            this.Salary = 10000;
            this.Department = "СВО";
        }
        public Worker(string Position, string FirstName) : this(Position, FirstName, string.Empty, 0, string.Empty)
        {
            this.LastName = "Фамилия_1";
            this.Salary = 10000;
            this.Department = "СВО";
        }
        public Worker(string Position) : this(Position, string.Empty, string.Empty, 0, string.Empty)
        {
            this.FirstName = "Имя_1";
            this.LastName = "Фамилия_1";
            this.Salary = 10000;
            this.Department = "СВО";
        }
   
    
        
    
    
    }
}
