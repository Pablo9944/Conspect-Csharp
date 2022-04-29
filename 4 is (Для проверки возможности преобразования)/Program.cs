using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_is__Для_проверки_возможности_преобразования_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomoSapiens hs = new HomoSapiens();
            Human human = hs;
            Creature creature = (Creature)human;
            Creature secondCreature = new Animal();

            if (secondCreature is Animal)
            {
                Console.WriteLine("Экземпляр имеет тип Animal");
            }


        }
    }

    class Creature { }

    class Animal : Creature { }

    class Human : Creature { }

    class HomoSapiens : Human { }
}
