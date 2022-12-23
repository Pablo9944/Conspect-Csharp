using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Фооновый_поток
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Фоновый поток позволяет остановить второй поток по завершению первого

            Thread thread = new Thread(new ThreadStart(WriteMessage));
            thread.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Primary");
                Thread.Sleep(500);
            }
            thread.IsBackground = true;

        }
        static void WriteMessage()
        {
            while (true)
            {
                Thread.Sleep(500);
                Console.WriteLine(new string(' ', 20) + "Secondary");
            }
        }
    }
   
}
