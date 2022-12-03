using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAIN_OF_RESPOSIBILITY_пример
{
    /// <summary>
    /// Абстрактный класс для всех обработчиков событий
    /// </summary>
    abstract class NotificationHandler
    {
        public NotificationHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}
