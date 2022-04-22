using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _2._6_Struct
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            #region MonthlyReport

            Random r = new Random();

            MonthlyReport[] report = new MonthlyReport[12];

            report[0] = new MonthlyReport()
            {
                Income = 500,
                consumption = 200,
                arrived = 111,          // Порядок занесения значений в переменные НЕ ВАЖЕН
                Mounth = "Январь"
            };
            
            report[1] = new MonthlyReport();
            report[1].Income = 1000;



            #endregion

            //Worker w = new Worker("Инженер", 10000, "Иван", "Иванов", new DateTime(1980,2,2));
            //Console.WriteLine(w.Print());

            Worker w1 = new Worker("dscs");
            Console.WriteLine(w1.Print());


            Into i = new Into { name = "Иван", age = 5 };
            Console.WriteLine(i.name + " " + i.age);



        }
    } 
}
