using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6._2_Описание_членов_структуры__индексаторы_
{
    public struct Repository2
    {
        private Worker [] Workers;

        //Индексатор - это более прокаченное свойство
        public Worker this [int index]
        {
            get { return Workers[index]; }
            set { Workers[index] = value; }
        }

        public Repository2(params Worker[]Args)
        {
            Workers = Args;
        }


    }
}
