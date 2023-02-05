using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReader__Пример_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = File.OpenText("sr.txt");

            // считываем пока не в конце потока
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                if (line!= null && line.Contains("Anton"))
                {
                    Console.WriteLine("Found");
                    Console.WriteLine(line);
                    
                }

            }
            sr.Close();
            Console.ReadKey();

            // Если файл уже существует, то перезапишит старый
            File.WriteAllText("sr.txt", "File.WriteAllText");

           
        }
    }
}
