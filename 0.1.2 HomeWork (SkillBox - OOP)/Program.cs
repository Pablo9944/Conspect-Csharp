using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._2_HomeWork__SkillBox___OOP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Consultant c = new Consultant(client);
            Manager m = new Manager(client);    
            
            
         
          
        }
    }
}
//Console.WriteLine($"Имя: {c.Name}| Фамилия: {c.Surname}| Отчество: {c.SecondName}|Телефон: {c.MobileTelephone}|Документ: {c.Document}|");