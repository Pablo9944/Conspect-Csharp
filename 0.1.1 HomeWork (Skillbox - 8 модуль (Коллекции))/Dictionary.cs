using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._1_HomeWork__Skillbox___8_модуль__Коллекции__
{
    public class Dictionary
    {
        
    
    
        public Dictionary<uint,string> AddContact()
        {
            bool flag = true;
            Dictionary<uint, string> tempDic = new Dictionary<uint, string>();
            uint Number = 0;
            string Name = string.Empty;
            do
            {
                
                string temp = null;
                Console.Write("Введите номер телефона: ");
                temp = Console.ReadLine();
                Check(temp, out Number);
                if (Number>0)
                {
                    flag = false;
                }
            }
            while (flag);
                
            Console.Write("Введите номер Имя: ");
                Name = Console.ReadLine();
                tempDic.Add(Number,Name);
                return tempDic;


        }
    
        private uint Check(string temp, out uint Number )
        {
            if (uint.TryParse(temp,out Number) == false )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введите корректное число!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return Number;
        }

        public void Print (Dictionary<uint, string> temp)
        {
            
            foreach (KeyValuePair<uint, string> e in temp)
            {
                Console.WriteLine(e);
            }
        }
    
    }
}
