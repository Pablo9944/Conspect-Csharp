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
                Array.Resize(ref arr, arr.Length * 3/2  );
            }

            arr[index++] = Element;
        }

        /// <summary>
        /// Удаление элемента. (не самое лучшее решение)
        /// </summary>
        /// <param name="Col"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool RemovAtt(ref int[] Col, int position)
        {
            bool result = false;
            if (position >= 0 && position <= Col.Length)
            {
                for (int index = position; index < Col.Length - 1; index++)
                {
                    Col[index] = Col[index + 1];

                }
                Array.Resize(ref Col, Col.Length - 1);
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }


        /// <summary>
        /// Удаляет элемент под указанной позицией (Это решение лучше)
        /// </summary>
        /// <param name="Position"></param>

        public void RemoveAt(int Position)
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
        public string Print(string Text = "")
        {
            string output = null;
            for (int i = 0; i < this.index; i++)
            {
                output += this.arr[i] + " ";
            }

            return $"{Text} {output}".Trim();
        }

        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int this[int i]
        { 
            get
            {
                return this.arr[i];
            }

            set
            {
                 this.arr[i] = value;
            }

        }

        /// <summary>
        /// Колличество элементов в массиве
        /// </summary>
        public int Count { get { return this.index; } }

        public void Length ()
        {
            Console.WriteLine(arr.Length);
        }
    }
}
