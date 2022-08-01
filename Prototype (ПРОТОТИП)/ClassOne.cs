using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype__ПРОТОТИП_
{
    /// <summary>
    ///  Первая конкретная реализация клонированного объекта
    /// </summary>
    class ClassOne : Prototype
    {
        public ClassOne(int id) : base(id)
        { }

        public override Prototype Clone()
        {
            return new ClassOne(Id);
        }
    }
}
