using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution_principle
{
    /// <summary>
    /// Внутренние рейсы
    /// </summary>
    public class DomesticFlight : Flight
    {
        public DomesticFlight(string name, List<string> passengers = null) : base(name, passengers)
        {
        }

        // Какой-то специфичный для внутренних рейсов функционал
    }
}
