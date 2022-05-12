using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _2._5_Работа_с_файлами__File__FileInfo__Directory__DirectoryInfo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = File.ReadAllText(@"D:\C#.txt"); //Открывыает файл,считывает вске строки,а затем закрывает файл
            string way = (@"D:\C#.txt");
            //string way1 = (@"D:\test.txt");
            ////Console.WriteLine(path);

            //string[] lines = File.ReadAllLines(@"D:\C#.txt");
            //Console.WriteLine(lines[0]);

            //lines = new string[] { "один", "два", "три" };
            //File.WriteAllLines(@"D:\C#.txt", lines);       //создает массив и записывает данные,если были данные то поверх перезаписывает

            //lines = new string[] { "один", "два", "три" };
            //File.AppendAllLines(@"D:\C#.txt", lines);

            //string path1 = File.ReadAllText(@"D:\test.txt"); //берет из файла текст и добавляет без замены в указанный файл
            //File.AppendAllText(@"D:\C#.txt", path1);

            //File.Delete(way); //удаляет файл

            //Console.WriteLine(File.Exists(way1));  //проверка на существования файла
            //File.Copy(way, @"D:\test.txt");  //создает новый файл и копирует данные из указанного файла

            //File.Move(@"D:\C#.txt", @"E:\C#.txt"); // переносит файл
            //Console.WriteLine(File.GetCreationTime(@"D:\C#.txt"));

            #region FileInfo
            FileInfo fileinfo = new FileInfo(way);

            //Console.WriteLine(fileinfo.Name); //имя файла
            //Console.WriteLine(fileinfo.ToString()); //путь расположения файла
            //Console.WriteLine(fileinfo.Extension); //получает расширения файла

            Console.WriteLine(fileinfo.CreationTime);
            #endregion


            #region Directory
            // Работа с директориями

            #endregion

            #region DirectoryInfo
            //DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\MyDir");

            // FileInfo[] array = directoryInfo.GetFiles();
            //foreach (var file in array)
            //{
            //    Console.WriteLine(file.Name);
            //}

            //DirectoryInfo directoryInfo1 = new DirectoryInfo(@"D:\");
            //DirectoryInfo[] array = directoryInfo1.GetDirectories();
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item.FullName);
            //}

            #endregion

            
         }

       }
    }
