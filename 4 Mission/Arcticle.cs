using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Mission
{
     class Arcticle
    {
      public string name { get;  set; }
      public  string nameStrore { get;  set; }
      uint cost;

        public uint Cost
        {
            set
            {
                if(value>=0)
                {
                    cost = value;
                }
                else
                {
                    Console.WriteLine("Стоииость не может быть отрицательной");
                }

            }
            get 
            {
                return cost;
            }
        }

        public string Info()
        {
            return name + " " + nameStrore + " " + cost;    
        }
    }
}
