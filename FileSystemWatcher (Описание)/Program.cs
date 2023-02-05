using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemWatcher__Описание_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Класс наблюдатель (может следить за дисками)
            FileSystemWatcher watcher = new FileSystemWatcher() { Path = @"D:\" };
            // Регистрация  обработчика события
            watcher.Created += WatcherChanged;
            watcher.Deleted += WatcherChanged;
            

            // Начать мониторинг
            watcher.EnableRaisingEvents = true;

            // ожидание результата (Ожидает когда какое событие произоёдет с файлом или папком на диске Д)
            var change = watcher.WaitForChanged(WatcherChangeTypes.All);
            Console.WriteLine(change.ChangeType);

            Console.ReadKey();
        }
        // Обработчик событий
        static void WatcherChanged(object sender,FileSystemEventArgs e)
        {
            Console.WriteLine(e.ChangeType + "1 " + e.FullPath);
        }
    }
}
