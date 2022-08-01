using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command__Пример_
{
    /// <summary>
    /// Адресат команды
    /// </summary>
    class Receiver
    {
        public void Operation()
        {
            Console.WriteLine("Процесс запущен");
        }
    }
}
