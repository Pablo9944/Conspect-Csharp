using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATEGY
{
    // <summary>
    /// Первая реализация алгоритма
    /// </summary>
    public class StrategyOne : IStrategy
    {
        public void Algorithm()
        { Console.WriteLine("Стратегия 1"); }
    }

    /// <summary>
    /// Вторая реализация алгоритма
    /// </summary>
    public class StrategyTwo : IStrategy
    {
        public void Algorithm()
        { Console.WriteLine("Стратегия 2"); }
    }
}
