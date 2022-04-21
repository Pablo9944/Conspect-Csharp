using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2._6._3_Пример
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"data.csv";
            Repository rep = new Repository(path);
            rep.Load();
            rep.PrintDbToCOnsole();
            Console.WriteLine(rep.Count);







        }
    }
}
