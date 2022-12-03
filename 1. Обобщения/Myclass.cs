using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Обобщения
{
    internal class Myclass <T>
    {
        public T Property { get; set; }

        public Myclass(T value)
        {
            Property = value;
        }

        public void GetInfoProperty()
        {
            Console.WriteLine($"type: {Property.GetType()} value: {Property}");
        }
    }
}
