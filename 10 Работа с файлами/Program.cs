using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10_Работа_с_файлами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Работа с файлами   GetDrives().СВОЙСТВА
/*AvailableFreeSpace: указывает на объем доступного свободного места на диске в байтах;
DriveFormat: получает имя файловой системы;
DriveType: представляет тип диска;
IsReady: готов ли диск (например, DVD-диск может быть не вставлен в дисковод);
Name: получает имя диска;
TotalFreeSpace: получает общий объем свободного места на диске в байтах;
TotalSize: общий размер диска в байтах;
VolumeLabel: получает или устанавливает метку тома.*/
#endregion

            #region Directory
            /*CreateDirectory(path): создает каталог по указанному пути;
            Delete(path): удаляет каталог по указанному пути;
            Exists(path): определяет, существует ли каталог по указанному пути; 
            GetDirectories(path): получает список каталогов в каталоге path;
            GetFiles(path): получает список файлов в каталоге path;
            Move(source, destination): перемещает каталог;
            GetParent(path): получение родительского каталога.
            CreateSubdirectory: создает подкаталог*/

            #endregion

            #region File
            /*File.Create: создает файл;
            File.Delete: удаляет файл;
            File.Copy: копирует файл;
            File.Move: перемещает файл;
            File.Exist(path): проверяет существование файла.*/

            #endregion

            #region FileInfo (Если необходимо выполнять много действий с одним файлом, то удобнее создать один раз объект класса FileInfo и работать через него.)
            /*Length: получить размер файла;
            Directory: получить ссылку на каталог(DirectoryInfo), в котором файл расположен;
            DirectoryName: получить путь к родительскому каталогу;
            Exist: проверить существование файла;
            Extension: получить расширение файла;
            Name и FullName: получить имя и полное имя соответственно.*/


            #endregion

            #region Основные типы специализированных потоков:
            /*FileStream: чтение и запись в файл.
            MemoryStream: представляет резервное хранилище в оперативной памяти, позволяет вести считывание и запись в него.
            NetworkStream: представляет сетевое хранилище. Поддерживает чтение и запись.
            PipeStream: поддерживает чтение из именованных каналов и запись в них и др.*/
            #endregion


            #region Работа с жестким диском
            //// получим системные диски
            //DriveInfo[] drives = DriveInfo.GetDrives();

            //// Пробежимся по дискам и выведем их свойства
            //foreach (DriveInfo drive in drives)
            //{
            //    Console.WriteLine($"Название: {drive.Name}");
            //    Console.WriteLine($"Тип: {drive.DriveType}");
            //    if (drive.IsReady)
            //    {
            //        Console.WriteLine($"Объем: {drive.TotalSize}");
            //        Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
            //        Console.WriteLine($"Метка: {drive.VolumeLabel}");
            //    }
            //}

            //Console.WriteLine();

            #endregion

            //GetCatalogs();


            DirectoryInfo d = new DirectoryInfo(@"F:\");
            Console.WriteLine($"Директорий -{d.GetDirectories().Length} Файлов -{d.GetFiles().Length}");

            FileInfo f = new FileInfo(@"F:\Пример.json");
            Console.WriteLine(f.Length);

            #region Пример подсчета размера папок через рекурсию

            DirectoryInfo directory = new DirectoryInfo(@"F:\");
            
            DirectoryExtension.DirSize(directory);
            #endregion


        }


        #region Пример работа с папками и файлами

        //static void GetCatalogs()
        //{
        //    string dirName = @"F:\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
        //    if (Directory.Exists(dirName)) // Проверим, что директория существует
        //    {
        //        Console.WriteLine("Папки:");
        //        string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

        //        foreach (string d in dirs) // Выведем их все
        //            Console.WriteLine(d);

        //        Console.WriteLine();
        //        Console.WriteLine("Файлы:");
        //        string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

        //        foreach (string s in files)   // Выведем их все
        //            Console.WriteLine(s);
        //    }


        //}


        

        #endregion

    }


}
