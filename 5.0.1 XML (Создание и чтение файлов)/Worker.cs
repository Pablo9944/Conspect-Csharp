using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0._1_XML__Создание_и_чтение_файлов_
{
  public class Worker
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public uint Salary { get; set; }
        public string Departament { get; set; }

        public Worker(string FirstName, string LastName, string Position, uint Salary, string Departament)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Position = Position;
            this.Salary = Salary;
            this.Departament = Departament;
        }
        public Worker()
        {

        }

        public void Print()
        {
            Console.WriteLine(this.FirstName + " " +
                              this.LastName + " " +
                              this.Position + " " +
                              this.Salary + " " +
                              this.Departament );
        }
    
        public void PrintList(List<Worker> temp)
        {
            foreach (var item in temp)
            {
                Console.WriteLine(item.FirstName + " " +
                                    item.LastName + " " +
                                    item.Position + " " +
                                    item.Salary + " " +
                                    item.Departament);
            }
        }
    }


}

