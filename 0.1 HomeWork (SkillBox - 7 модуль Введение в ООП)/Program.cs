using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1_HomeWork__SkillBox___7_модуль_Введение_в_ООП_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string path = @"D:\Workers.csv";
            
            Repository rp = new Repository(path,new Workers(DateTime.Now, $"Фамилия", $"Имя", $"Отчество", r.Next(18, 30), r.Next(170, 199), r.Next(1, 31), "Russia"));
            rp.AddWorker(5);
            rp.ReadWorker();
            Console.ReadKey();
            Console.WriteLine();
            rp.DelUsers(2);
            rp.ReadWorker();
            


            

            
            













        }
    
    

    
    
    
    }
}
