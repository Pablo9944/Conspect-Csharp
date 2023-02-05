using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList__Mission_
{
    public interface IMyList<T>
    {
        void Add(T value);
        T this[int index] { get; }

        int Count { get; }

        void Clear();
        bool Contains(T value);
    }
}
