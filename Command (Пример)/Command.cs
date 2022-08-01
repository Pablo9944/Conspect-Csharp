using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command__Пример_
{
    /// <summary>
    /// Базовый класс команды
    /// </summary>
    abstract class Command
    {
        public abstract void Run();
        public abstract void Cancel();
    }
}
