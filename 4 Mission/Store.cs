using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Mission
{
     class Store: Arcticle
    {
       
        
      public  Arcticle[] arcticles;

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < arcticles.Length)
                {
                    return arcticles[index].Info();
                }
                return "Попытка обращения за пределы массива";
            }

       
        }

        
        public Store()
        {
            arcticles = new Arcticle[3];
            
        }

        public void AddArcticle(Arcticle value, int index)
        {
            if (index >= 0 && index < arcticles.Length)
            {
                arcticles[index] = value;
                
            }
            else
            {
                Console.WriteLine("Попытка обращения за пределы массива");
            }
        }
     
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < arcticles.Length; i++)
                {
                    if (arcticles[i].name == index)
                    {
                        return arcticles[i].Info();
                    }
                }

                return $"нет в наличи {index}";
            }
        }
        
    }
}
