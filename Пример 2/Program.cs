using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(@"D:\");
            watcher.Renamed += new RenamedEventHandler(WatcherRenamed);

             watcher.EnableRaisingEvents= true;


            Console.ReadKey();

        }
        static void WatcherRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Старое имя - {e.OldName} || новое имя {e.Name}");
        }
    }
}
