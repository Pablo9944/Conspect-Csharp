using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype__ПРОТОТИП_
{
    /// <summary>
    /// Общий интерфейс для клонирования похожих объектов
    /// </summary>
    abstract class Prototype
    {
        protected int Id;

        // Метод-конструктор
        public Prototype(int id)
        {
            Id = id;
        }

        // Метод для клонирования самого себя
        public abstract Prototype Clone();
    }
}
