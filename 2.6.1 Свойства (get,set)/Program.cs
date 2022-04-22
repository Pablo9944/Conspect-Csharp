using _2._6_Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;




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


            //Модификатор для блока set или get можно установить, если свойство имеет оба блока (и set, и get).
            //Только один из блоков set / get может иметь модификатор доступа, но не оба сразу.
            //Модификатор доступа блока set/ get должен быть более ограничивающим, чем модификатор доступа свойства.Например, если свойство имеет модификатор public, то блок set/get может иметь только модификаторы,
            //с использованием которых блок будет менее доступен: protected internal, internal, protected, private.

            Cat c = new Cat("Британец", "Кот", 2);


            c.Nickname = "Пушок";
            Console.WriteLine(c.Nickname.ToString());

            c.Breed = "Сибирский";
            Console.WriteLine(c.Breed.ToString());

            c.Height = 4;
            Console.WriteLine(c.Height.ToString());

            User u = new User();
            u.Age = 16;
            Console.WriteLine(u.Age);

            u.Email = "foxaa@yandex.ru";
            Console.WriteLine(u.Email);

        }
    }

    class User
    {
        private int age;

        public int Age
        {
            get { return age; }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Вы пиздюк");
                }
                else
                {
                    age = value;
                }
            }
        }


        private string email;

        public string Email
        {
            get 
            { 
                return email; 
            }
            
            set 
            {
                if (!value.Contains('@'))
                {
                    Console.WriteLine("Вы ввели некорректный адрес");
                }
                else
                {
                    email = value;
                }
            }
        }
        


    }

}
