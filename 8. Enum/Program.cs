using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Person p = new Person(Workers.Manager, "Ivan", 200);
            p.PrintResultSalary();

          
        }
    }

     enum Workers
    {
        Manager = 190,
        Cleaner = 200,
        Developer = 190  
    }
    
    class Person
    {
       public Workers w;

        public string name;
        int hours;

        public Person(Workers w, string name,int hours)
        {
            this.w = w;
            this.name = name;  
            this.hours = hours;
        }

         bool Premia()
        {
            if (hours <= (int)w )
            {
                return false;
            }
            return true;
        }

        public void PrintResultSalary()
        {
            if (Premia())
            {
                Console.WriteLine("Получите премию!");
               
            }
            else
            {
                Console.WriteLine("Сосните хуетца=)");
            }
            
        }
    }
}
