using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6.Итоговый_проект
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var Anketa = EnterUser();
            Print(Anketa.Name, Anketa.Surname, Anketa.Age, Anketa.Pets, Anketa.Nickname, Anketa.favcolors);
        }



        static (string Name, string Surname, uint Age, bool Pets, string[] Nickname, string[] favcolors) EnterUser()
        {
            (string Name, string Surname, uint Age, bool Pets, string[] Nickname, string[] favcolors) Users;

            #region Имя и Фамилия

            Console.Write("Введите ваше Имя: ");
            Users.Name = Console.ReadLine();

            Console.Write("Введите вашу Фамилию: ");
            Users.Surname = Console.ReadLine();

            #endregion

            #region Попытка получения возраста
            bool flag = true;

            do
            {
                Console.Write("Укажите Ваш возраст: ");
                string age = Console.ReadLine();
                Users.Age = 0;
                Check(age, out Users.Age);
                if (Users.Age == 0)
                {
                    continue;
                }
                flag = false;


            } while (flag);
            #endregion

            #region Информация про животных


            do
            {
                Console.Write("Увас есть питомец Д/Н?: ");
                Users.Pets = false;
                Users.Nickname = null;
                char key = Console.ReadKey().KeyChar;
                if (char.ToUpper(key) == 'Д' || char.ToUpper(key) == 'Н')
                {
                    if (char.ToUpper(key) == 'Д')
                    {
                        Users.Pets = true;
                        Console.Write("\nСколько у вас животных?: ");
                        uint countPets = 0;
                        string temp = Console.ReadLine();
                        Check(temp, out countPets);
                        if (countPets > 0)
                        {
                            Users.Nickname = new string[countPets];
                            for (int i = 0; i < Users.Nickname.Length; i++)
                            {
                                Console.Write("Как {0} - зовут: ", (i + 1));
                                Users.Nickname[i] = Console.ReadLine();
                            }
                            break;
                        }
                    }

                    if (char.ToUpper(key) == 'Н')
                    {
                        Console.WriteLine();
                        Users.Pets = false;
                        break;


                    }
                    Console.WriteLine();


                }

                else
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nУкажите корректные данные Д/Н");
                    Console.ForegroundColor = ConsoleColor.White;
                    flag = true;

                }

            } while (flag);
            #endregion

            #region Ввод цвета

            do
            {

                Console.Write("Сколько у Вас любимых цветов: ");
                int countCollors = 0;
                Users.favcolors = null;

                string colors = (Console.ReadLine());
                bool result = int.TryParse(colors, out countCollors);
                if (result == true && countCollors != 0)
                {
                    Users.favcolors = new string[countCollors];
                    for (int i = 0; i < Users.favcolors.Length; i++)
                    {
                        Console.Write("Введите {0} - цвет: ", (i + 1));
                        Users.favcolors[i] = Console.ReadLine();
                        flag = false;
                    }
                }
                if (result == false || countCollors == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите корректное значение ");
                    Console.ForegroundColor = ConsoleColor.White;
                    flag = true;
                }

            } while (flag);

            #endregion



            return Users;


        }


        static uint Check(string tempAge, out uint age)
        {
            if (uint.TryParse(tempAge, out age) == false || age == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы указали неверное значение,попробуйте еще раз");
                Console.ForegroundColor = ConsoleColor.White;

            }

            return age;
        }

        static void Print(string Name, string Surname, uint Age, bool Pets, string[] Nickname, string[] favcolors)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"\tВас зовут {Name}\n");
            Console.Write($"\tВаша фамилия {Surname}\n");
            Console.Write($"\tВаш возраст {Age}\n");
            Console.Write($"\tНаличие животных {Pets}\n");
            if (Pets == true)
            {
                for (int i = 0; i < Nickname.Length; i++)
                {
                    Console.Write($"\t{i + 1}-го зовут {Nickname[i]}\n");

                }
            }
            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.Write($"\t{i + 1} цвет {favcolors[i]}\n");

            }
        }






    }
}

