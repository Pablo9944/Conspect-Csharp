using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6._2_Описание_членов_структуры__индексаторы_
{
    struct Repository1
    {
        public Worker[] Workers; // переменная массив

        public Repository1(params Worker[] Args)   // конструктор
        {
            Workers = Args;
        }
    }
}
