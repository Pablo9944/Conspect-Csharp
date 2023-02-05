using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Path__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "TestPath.exe";

            Console.WriteLine($"Тип файла - {Path.GetExtension(path)}") ;
            Console.WriteLine("Меням расширение файла на txt");
            path = Path.ChangeExtension(path, "txt");
            Console.WriteLine($"Новый тип файла - {Path.GetExtension(path)}");

        }
    }
}
