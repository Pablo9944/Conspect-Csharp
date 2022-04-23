using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0_Коллекции_пространство_System.Collections.Generic__коллекция_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arr arr = new Arr(3);
            Console.WriteLine(arr.Print("Тест 1:"));

            arr.Add(1);
            Console.WriteLine(arr.Print("Тест 2:"));

            arr.Add(2);
            arr.Add(3);
            Console.WriteLine(arr.Print("Тест 3:"));

            Random r = new Random();

            for (int i = 0; i < 30; i++)
            {
                arr.Add(r.Next(0,10));
            }
            Console.WriteLine(arr.Print("Тест 4:"));

            arr.Add(11235813);
            Console.WriteLine(arr.Print("Тест 5:"));
            Console.WriteLine(arr.Count); 
            arr.Length();

        }
    
    
    
        
    }
}
