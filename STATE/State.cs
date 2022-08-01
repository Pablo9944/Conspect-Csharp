using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_пример
{
    /// <summary>
    /// Общий интерфейс, определяющий состояния
    /// </summary>
    abstract class State
    {
        public abstract void Handle(ContextObject contextObject);
    }
}
