using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution_principle
{
    /// <summary>
    /// Базовый класс для всех полетов
    /// </summary>
    public abstract class Flight
    {
        public string Name;
        public List<string> PassengerList;

        public Flight(string name, List<string> passengers = null)
        {
            Name = name;
            PassengerList = passengers ?? new List<string>();
        }
        // Подсчет количества пассажиров
        public void CountPassengers()
        {
            Console.WriteLine($"На рейсе {Name} {PassengerList.Count} пассажиров");
        }


    }
}
