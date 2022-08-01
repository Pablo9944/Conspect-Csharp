using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype__ПРОТОТИП_
{
    /// <summary>
    /// Вторая конкретная реализация клонированного объекта
    /// </summary>
    class ClassTwo : Prototype
    {
        public ClassTwo(int id) : base(id)
        { }

        public override Prototype Clone()
        {
            return new ClassTwo(Id);
        }
    }
}
