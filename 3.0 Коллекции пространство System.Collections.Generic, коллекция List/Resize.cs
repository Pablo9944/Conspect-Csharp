using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0_Коллекции_пространство_System.Collections.Generic__коллекция_List
{
    struct Arr
    {
        int[] arr;
        int index;

        /// <summary>
        ///  Конструктор принимающий размер массива
        /// </summary>
        /// <param name="SizeArray"></param>
        public Arr(int SizeArray)
        {
            this.arr = new int[SizeArray];
            this.index = 0;
        }

        /// <summary>
        /// Добавляет указанный элемент в массив (Дополнительно осуществляет проверку размерности массива)
        /// </summary>
        /// <param name="Element"></param>
        public void Add(int Element)
        {
            if (index >= arr.Length)
            {
                Array.Resize(ref arr, arr.Length * 2 / 3);
            }

            arr[index++] = Element;
        }

        /// <summary>
        /// Удаляет элемент под указанной позицией
        /// </summary>
        /// <param name="Position"></param>
        public void RemoveAt (int Position)
        {
       
            for (int i = Position; i < this.index; i++)
            {
                arr[i] = arr[i + 1];
            }

            this.index--;
            Console.WriteLine(arr[0]);
       
        }

        /// <summary>
        /// Выводит на экран
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public string Print (string Text =  "")
        {
            string output = null;
            for (int i = 0; i < this.index; i++)
            {
                output += this.arr[i];
            }

            return $"{Text} {output}".Trim();
        }


    }
}
