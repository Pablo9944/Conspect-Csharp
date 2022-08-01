using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATEGY__Пример_
{
    /// <summary>
    /// Общий интерфейс отопительных котлов
    /// </summary>
    interface IHeater
    {
        //  Нагрев
        void Heat();
    }
}
