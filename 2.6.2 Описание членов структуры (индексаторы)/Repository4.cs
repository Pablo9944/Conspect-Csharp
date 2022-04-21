using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6._2_Описание_членов_структуры__индексаторы_
{
    struct  Repository4
    {
        private Worker[] Works;

        public string this [string i]
        {
            get 
            {
                switch (i)
                {
                    case "+": return "Плюс";
                    //case "-": Console.WriteLine("Минус"); break;
                    //case "*": Console.WriteLine("Умножить");break;
                    //case "/": Console.WriteLine("Разделить");break;
                    default: return "Что-то другое"; 
                }

            }
            
        }
        public Repository4 (params Worker[] Arg)
        {
            Works = Arg;
        }

        public int this[int i]
        {
            set
            {
                if (i<0)
                {
                    value = 5;
                }
                else
                {
                    value = 7;
                }
            }
            get
            {
                switch (i)
                {
                    case 1: return 2;
                    //case "-": Console.WriteLine("Минус"); break;
                    //case "*": Console.WriteLine("Умножить");break;
                    //case "/": Console.WriteLine("Разделить");break;
                    default: return i;
                }
            }
        
        }

    }
}
