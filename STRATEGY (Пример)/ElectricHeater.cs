using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATEGY__Пример_
{
    /// <summary>
    /// Реализация электрического отопления
    /// </summary>
    class ElectricHeater : IHeater
    {
        public void Heat()
        {
            Console.WriteLine("Нагрев электричеством");
        }
    }
}
