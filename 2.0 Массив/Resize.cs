using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._0_Массив
{
    struct Resize
    {
        int[] arr;
        int index;

        public Resize(int SizeArray)
        {
            this.arr = new int[SizeArray];
            this.index = 0;
        }

        public void Add (int Element)
        {
            if (index >= arr.Length)
            {
                Array.Resize(ref arr, arr.Length * 2 / 3);
            }

            arr[index++] = Element;
        }

    }
}
