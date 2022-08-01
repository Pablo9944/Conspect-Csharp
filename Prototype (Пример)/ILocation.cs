using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype__Пример_
{
    /// <summary>
    /// Общий интерфейс для объектов на карте
    /// </summary>
    interface ILocation
    {
        /// Метод для клонирования
        ILocation Clone();

        // Метод для получения информации об объекте
        void GetInfo();
    }
}
