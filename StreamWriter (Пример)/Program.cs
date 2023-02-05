using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriter__Пример_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("sw.txt");

            StreamWriter sw = file.CreateText();

            

            sw.WriteLine("bjhbjgjgjgju");
            sw.WriteLine("2");

            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(i);
            }

            sw.Close();

        }
    }
}
