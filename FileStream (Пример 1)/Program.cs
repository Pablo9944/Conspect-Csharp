using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream__Пример_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"1.txt";

            FileInfo file = new FileInfo(path);

            Console.WriteLine(file.FullName);
            Console.WriteLine(file.Length);

            // создаем поток 
                              // открывает или создает   // только для чтения    // Совместный доступ (можно сделать чтобы можно было и окрывать и записывать одновременно)
            FileStream fs = file.Open(FileMode.Open,         FileAccess.Read,     FileShare.None);



            using (StreamReader sr = new StreamReader(fs))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            file.Delete();

            }
    }
    
}
