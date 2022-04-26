using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._1_HomeWork__Skillbox___8_модуль__Коллекции__
{
    public class List
    {
        List<int> list = new List<int>();
        Random r  = new Random();

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }


        public List()
        {
            for (int i = 0; i < 100; i++)
            {
                list.Add(r.Next(0, 100));
            }

        }
   
    
        public void Remove()
        {
            List<int> listTemp = new List<int>();

            
            foreach (var e in list)
            {
                if (e<25 || e>50)
                {
                    listTemp.Add(e);
                    
                }
       
            }
            list = listTemp;
          


        }
    
    
        public void Print()
        {
            int count = 0;
            foreach (var e in list)
            {
                Console.WriteLine(e);
                count++;
            }
            this.count = count;
        
        }
    
    
    }
}
