using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATEGY
{
    /// <summary>
    /// Клиентский код
    /// </summary>
    public class Client
    {
        public IStrategy ClientStrategy { get; set; }

        public Client(IStrategy strategy)
        {
            ClientStrategy = strategy;
        }

        // Выполнение стратегии
        public void ExecuteAlgorithm()
        {
            ClientStrategy.Algorithm();
        }
    }
}
