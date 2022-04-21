using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6._2_Описание_членов_структуры__индексаторы_
{
    public struct Repository3
    {
        private Worker []  Workers;

        public string this [int index]  
        {
            get { return this.Workers[index].Print() ; }
          
        }
        public Repository3(params Worker[]Args )
        {
            Workers = Args;
        }
    }
}
