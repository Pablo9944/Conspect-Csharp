using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._1_HomeWork__Skillbox___8_модуль__Коллекции__
{
    public class HashSets
    {
        public HashSets()
        {
            HashSet<int> set = new HashSet<int>();
        }

     
    
        public void Add()
        {
            bool flag = true;
            HashSet<int> check = new HashSet<int>();
            int number = 0;
            int tempNumber = 0;
            do
            {
              Console.Write("Введите число: ");
              number = int.Parse(Console.ReadLine());
              if(Check(check, number))
              {
                    check.Add(number);
              }
             

            } while (flag);
        }


        public bool Check(HashSet<int> check, int number)
        {
            bool cheking = false;

            if (!check.Contains(number))
            {
                Console.WriteLine("Число успешно добавлено");
                cheking = true;
            }

            if (check.Contains(number))
            {
                Console.WriteLine("Число находится в коллекции");
                cheking = true;
            }

            return cheking;
        }
    }
}
