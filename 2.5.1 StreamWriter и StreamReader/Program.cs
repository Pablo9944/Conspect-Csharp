using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2._5._1_StreamWriter_и_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StreamWriter и StreamReader
            //DirectoryInfo[] dir = new DirectoryInfo(@"D:\").GetDirectories();
            //string path = (@"D:\cDirs.txt");

            //  Console.WriteLine(File.Exists(path));
            ////  if (!File.Exists(path))
            //  {
            //      File.Create(path);
            //      foreach (var item in dir)
            //      {
            //          File.AppendAllText(path, item.FullName.ToString() + Environment.NewLine);
            //          Console.WriteLine();
            //      }
            //  }
            //// else
            //  {
            //      foreach (var item in dir)
            //      {
            //          File.AppendAllText(path, item.FullName.ToString() + Environment.NewLine);
            //          Console.WriteLine();
            //      }
            //  }

            //StreamWriter streamWriter = new StreamWriter("cDirs.txt"); // Создание потока для работы с файлом cDirs.txt

            //foreach (DirectoryInfo Dir in dir)
            //{
            //    streamWriter.WriteLine(Dir.Name);  // !Если меньше 4кб то не выгружает на диск
            //    Console.WriteLine(Dir.Name);
            //}
            //streamWriter.Flush(); // Очистить текущий буфер.(записывает файлы даже если меньше 4кб)
            //streamWriter.Close(); // закрывает поток


            //using (StreamWriter sw = new StreamWriter(path))  //автоматически закрывает поток
            //    foreach (DirectoryInfo Dir in dir)
            //    {
            //        sw.WriteLine(Dir.Name);  // !Если меньше 4кб то не выгружает на диск
            //        Console.WriteLine(Dir.Name);
            //    }


            //using (StreamWriter sr = new StreamWriter(path))  //автоматически закрывает поток
            //{
            //    sr.EndOfStream
            //}
            #endregion


            #region StreamReader Поток для чтения

            //using (StreamReader sr = new StreamReader(@"D:\C#.txt"))
            //{
            //    while (!sr.EndOfStream) // пока поток не закончен считываем по одной строчке
            //    {
            //        Console.WriteLine(sr.ReadLine()); //Записать текущее имя каталога в файл . Считываем ст року и выводим на консоль
            //    }
            //}


            #endregion

            #region StreamWriter поток для записи StreamReader

            //string path = @"D:\db.csv";
            //if (!File.Exists(path))
            //{
            //    File.AppendText(path);
            //}

            //using (StreamWriter sw = new StreamWriter("db.csv", true, Encoding.Unicode))
            //{
            //    char key = 'д';

            //    do
            //    {
            //        string note = null;
            //        Console.Write("Введите имя автора записи: ");
            //        note += $"{Console.ReadLine()}\t";

            //        string now = DateTime.Now.ToShortTimeString();
            //        Console.WriteLine($"Время заметки {now}");
            //        note += $"{now}\t";

            //        Console.Write("Введите описание заметки: ");
            //        note += $"{Console.ReadLine()}\t";
            //        sw.WriteLine(note);
            //        Console.Write("Продолжить н/д: " + Environment.NewLine);
            //        key = Console.ReadKey(true).KeyChar;

            //    } while (char.ToLower(key) == 'д');


            //}




            ////чтение

            //using (StreamReader sr = new StreamReader("db.csv",Encoding.Unicode))
            //{
            //    string line;
            //    Console.WriteLine($"{"Автор",15}{" Время",8} {" Описание"}");
            //    while ((line = sr.ReadLine()) != null) // будет считывание строки пока не будет пустой
            //    {
            //        string[] data = line.Split('\t');
            //        Console.WriteLine($"{data[0],15}{data[1],8}{data[2]}");
            //    }
            //}

            //Console.ReadLine();





            #endregion

            #region StringBuilder Предоставляет изменяемую строку символов StringWriter,StringReader         
            StringBuilder sb = new StringBuilder("Првет");
            Console.WriteLine(sb.Length); // длина
            Console.WriteLine(sb.Capacity); // покажет сколько можно записать числов знаков в памяти в  текущем экземпляре (вместимость)

            StringBuilder sb1 = new StringBuilder(100); // Выделяем экземпляр под 100 символов
            Console.WriteLine(sb1.Length);
            Console.WriteLine(sb1.Capacity);
            sb1.Append("test");
            Console.WriteLine(sb1.Length);
            Console.WriteLine(sb1.Capacity);

            sb1[2] = '3';
            Console.WriteLine(sb1.ToString());
           


            #endregion

        }
    }
}
