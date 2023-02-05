using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Копирование
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("sr.txt");
            string path = @"C:\Users\foxaa\source\repos\-sharp-\Копирование\TestCopy.txt";

            try
            {
                file.CopyTo(path);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
