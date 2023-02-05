using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInfo__Описание_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\";
                                               // о директории где находится исполняемый файл (папка проекта)
            DirectoryInfo dir = new DirectoryInfo(@".");
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.Root);
            Console.WriteLine(dir.Parent);
            Console.WriteLine(dir.Attributes);
            Console.WriteLine(dir.LastAccessTime);
            Console.WriteLine(dir.LastWriteTime);

            Console.WriteLine(new string('-',20));

            FileInfo[] fileInfo = dir.GetFiles();
            foreach (FileInfo file in fileInfo) 
            {
                Console.WriteLine(file.FullName);
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Attributes);
                Console.WriteLine(file.LastAccessTime);
                Console.WriteLine(file.LastWriteTime);
                Console.WriteLine(file.CreationTime);
                Console.WriteLine(new string('-', 20));
            }

            Console.WriteLine();
            Console.WriteLine();

            FileInfo[] fileinfo_2 = dir.GetFiles("*.txt");
            foreach (FileInfo file_2 in fileinfo_2)
            {
                Console.WriteLine(file_2.FullName);
                Console.WriteLine(file_2.Name);
                Console.WriteLine($"Размер файла в байтах - {file_2.Length}");
                Console.WriteLine(file_2.CreationTime);
                Console.WriteLine(new string('-', 20));

            }

        }
    }
}
