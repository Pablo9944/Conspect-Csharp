using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Кортежи
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (string name, int age) anketa;

            //var anketa = (name: "Jane", age: 27);

            //Console.WriteLine("Ваше имя: {0}", anketa.name);
            //Console.WriteLine("Ваш возраст: {0}", anketa.age);

            //var (name, age) = ("Евгения", 27);
            //Console.WriteLine("Ваше имя: {0}", name);
            //Console.WriteLine("Ваш возраст: {0}", age);

            //(string, int) test;
            //test = ("sss", 5);
            //Console.WriteLine(test.Item1);


            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;
            //Console.WriteLine("Введите имя");
            //User.Name = Console.ReadLine();
            //Console.WriteLine("Введите фамилию");
            //User.LastName = Console.ReadLine();
            //Console.WriteLine("Введите логин");
            //User.Login = Console.ReadLine();
            //User.LoginLength = User.Login.Length;
            //Console.WriteLine("Есть ли у вас животные? Да или Нет");
            //string result = Console.ReadLine();
            //if (result == "Да")
            //{
            //    User.HasPet = true;
            //}

            //else if (result == "Нет")
            //{
            //    User.HasPet = false;
            //}
            //Console.WriteLine("Введите возраст пользователя");
            //User.Age = double.Parse(Console.ReadLine());
            User.favcolors = new string[3];
            //Console.WriteLine("Введите три любимых цвета пользователя");
           
            for (int i = 1; i < User.favcolors.Length; i++)
            {
                Console.Write("Укажите {0} - ый цвет: ",++i);
                i--;
                User.favcolors[i] = Console.ReadLine();

            }

            //Console.WriteLine(User.Name);
            //Console.WriteLine(User.LastName);
            //Console.WriteLine(User.Login);
            //Console.WriteLine(User.LoginLength);
            //Console.WriteLine(result);
            //foreach (var item in User.favcolors)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(User.Age);







        }
    }
}
