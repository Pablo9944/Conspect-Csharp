using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_as__Проверка_на_null_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomoSapiens hs = new HomoSapiens();
            Human human = hs;
            Creature creature = (Creature)human;
            Creature secondCreature = new Animal();

            object obj = "";

            Animal a = obj as Animal;

            if (a != null)
            {
                Console.WriteLine("Преобразование прошло успешно");
            }


            Animal animal = secondCreature as Animal;

            if (animal != null)
            {
                // Использование значения animal
            }
        }
    }
    class Creature { }

    class Animal : Creature { }

    class Human : Creature { }

    class HomoSapiens : Human { }
}
