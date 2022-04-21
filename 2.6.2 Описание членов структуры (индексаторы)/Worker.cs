using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6._2_Описание_членов_структуры__индексаторы_
{
    public struct Worker
    {
        public string Position { get; set; }
        public uint Salary { get; set; }

        public string FirstName { get; set; }

        public string Print()
        {
            return Position + " " + Salary + " " + FirstName;
        }

        public Worker(string Position, uint Salary, string FirstName)
        {
            this.Position = Position;
            this.Salary = Salary;
            this.FirstName = FirstName;

        }
    
        
    
    }
}
