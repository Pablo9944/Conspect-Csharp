using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution_principle
{
    /// <summary>
    /// Международные рейсы
    /// </summary>
    public class InternationalFlight : Flight
    {
        public InternationalFlight(string name, List<string> passengers = null) : base(name, passengers)
        {
        }

        // Какой-то специфичный для международных рейсов функционал
    }
}
