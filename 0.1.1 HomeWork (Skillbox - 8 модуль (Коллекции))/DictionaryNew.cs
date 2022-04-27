using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._1_HomeWork__Skillbox___8_модуль__Коллекции__
{
    public class Dictionary
    {


        public Dictionary<List<string>, string>  AddContact()
        {
            Dictionary<List<string>, string> dic = new Dictionary<List<string>, string>();
            List<string> Number = new List<string>();
            string Numbers = null;
            string FIO = null;
            string YesNoCheck = null;


            bool flag = true;
            Console.Write("Введите Имя: ");
            FIO = Console.ReadLine();

            do
            {
               

                Console.Write("Введите номер телефона: ");
                Numbers = Console.ReadLine();
                if (Numbers != "")
                {
                    Number.Add(Numbers);

                }
                if (Numbers == "")
                {
                    dic.Add(Number, FIO);
                    flag = false;
                }
            
                
             }

            while (flag);

            return dic;
        }

       public void Print (Dictionary<List<string>, string> temp)
        {
            
            foreach (List<string> Key in temp.Keys)
            {
                foreach (var key in Key)
                {
                    Console.WriteLine(key);

                }
                foreach (string Value in temp.Values)
                {
                    Console.Write($"\t\t{Value}");

                }

            }
        }

        public void Find(Dictionary<List<string>, string> temp,string value)
        {
            string st = "";

            foreach (var item in temp.Keys)
            {
                if (item.Contains(value))
                {
                    if (temp.TryGetValue(item,out st))
                    {
                        Console.WriteLine(st);
                    }
                   
                    
                }
           
            
                else
                {
                    Console.WriteLine("Пользователь не найден");
                }
            
            
            }
          
            
            
        }
    }
}
