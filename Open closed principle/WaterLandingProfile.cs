using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_closed_principle
{
    public class WaterLandingProfile : ILandingProfile
    {
        /// <summary>
        /// Профиль для посадки на воду
        /// </summary>
        public void Execute()
        {
            Console.WriteLine(">> Загружен профиль: ПОСАДКА НА ВОДУ <<");

            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Опускаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Поднимаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("--ПОСАДКА--");
        }
    }
}