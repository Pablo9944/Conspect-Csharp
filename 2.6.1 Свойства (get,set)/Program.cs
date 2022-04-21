using _2._6_Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2._6._1_Свойства__get_set_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Прописка из другого решения в текущий (Struct,Class)
            //В текущим решении нажимаем на ссылки, ПК => решения => выбираем нужное решение => ОК =>
            //в текушим решении пишим название структуры или класса появляется лампочка => в лампочке добавить необходиый using

            #endregion

            Cat c = new Cat("Британец", "Кот", 2);


            c.Nickname = "Пушок";
            Console.WriteLine(c.Nickname.ToString());

            c.Breed = "Сибирский";
            Console.WriteLine(c.Breed.ToString());

            c.Height = 4;
            Console.WriteLine(c.Height.ToString());



        }
    }
}
