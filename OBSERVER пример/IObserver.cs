using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVER_пример
{
    /// <summary>
    /// Общий интерфейс наблюдателя
    /// </summary>
    interface IObserver
    {
        void Update(Object o);
    }
}
