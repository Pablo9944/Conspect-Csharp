using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfo__Описание_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Инфориация о  папках DirectoryInfo.GetDirectories()
            // dir.FullName -  Полное имя директории (включая путь)
            // dir.Name     -  Имя директории (Не включая путь)
            // dir.Parent   -  Родительская директория
            // dir.CreationTime - Время создания директории
            // dir.Attributes   - Аттрибуты (показывает тип Папок (скрытые или только для чтения))
            // dir.Root         - Корневой диск, на котором находится директория
            // dir.LastAccessTime  - Время последнего доступа к директории
            // dir.LastWriteTime   - Время последнего изменения файлов в директории

            #endregion


            string path = @"D:\";
            DirectoryInfo dir = new DirectoryInfo(path);

            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                if (d.Attributes != FileAttributes.Hidden)
                {
                    Console.WriteLine(d.FullName);
                }
                continue;
            }


        }
    }
}
