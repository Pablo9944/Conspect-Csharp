using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Сопоставление_шаблонов___Pattern_Matching__для_оператора_is
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomoSapiens hs = new HomoSapiens();
            Human human = hs;
            Creature creature = (Creature)human;
            Creature secondCreature = new Animal();

            HomoSapiens h = new Myclass();

            object o = "";
            Bar(o);


            if (secondCreature is Animal animal)
            {

                // Сразу после проверки типа помещает данные в обьект класса animal
                // Использование значения animal
            }
        }
    
    
        static void Bar(object obj)
        {
            if (obj is Myclass my)
            {
                my.Print();
            }
        }
    
    }
    class Creature { }

    class Animal : Creature { }

    class Human : Creature { }

    class HomoSapiens : Human { }

    class Myclass: HomoSapiens
    {
        public int x { get; set; }
        public int y { get; set; }
        public void Print()
        {
            Console.WriteLine("Сразу после проверки типа помещает данные в обьект класса animal");
        }
    }
}
