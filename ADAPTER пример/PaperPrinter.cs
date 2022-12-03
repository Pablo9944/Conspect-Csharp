using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAPTER_пример
{
    class PaperPrinter : IPrinter
    {
        /// <summary>
        /// Класс для работы с принтером
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Печатаем на бумаге");
        }
    }
}
