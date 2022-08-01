using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUILDER__строитель_
{
    /// <summary>
    /// Реализация продукта - сложного объекта
    /// </summary>
    class Product
    {
        // список частей, из которых состоит объект
        List<object> parts = new List<object>();

        /// Метод для поэтапного процесса создания
        public void Add(string part)
        {
            parts.Add(part);
        }
    }
}
