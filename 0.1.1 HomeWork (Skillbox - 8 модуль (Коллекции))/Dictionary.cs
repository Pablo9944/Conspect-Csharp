//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _0._1._1_HomeWork__Skillbox___8_модуль__Коллекции__
//{
//    public class Dictionary
//    {


//        public Dictionary<string, List<string>> AddContact()
//        {
//            string YesNoCheck = null;
//            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
//            List<string> list = new List<string>();
//            bool flag = true;
//            do
//            {
//                Console.Write("Введите ФИО: ");
//                string FIO = Console.ReadLine();
//                dic.Add(FIO,list);
//                do
//                {
//                    Console.Write("Введите номер телефона (Если больше не будет номеров телефона просто нажмите \"Enter\": ");
//                    string temp = Console.ReadLine();
      
//                    if (temp == "")
//                    {
//                        flag = false;
//                    }
//                    else
//                    {

//                        dic[FIO].Add(temp);
                           
                        
//                    }

//                }

              
//                while (flag);

//                Console.Write("Добавлять имена с телефонами еще будите? Да/Нет ");
//                YesNoCheck = Console.ReadLine().ToLower();
//                if (YesNoCheck == "нет")
//                {
//                    flag = false;
//                }

//            } while (flag);

//            return dic;
//        }



//        public void Print(Dictionary<string, List<string>> temp)
//        {
//            foreach (var e in temp.Keys)
//            {
//                Console.Write($"{e}");
//                foreach (var item in temp[e])
//                {
//                    Console.WriteLine($"\t{item, 5}");
//                }
//            }
//        }

//    }
//}
