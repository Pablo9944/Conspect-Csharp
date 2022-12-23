using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._1_Рекурсия_интересный_пример__c_циком_for_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Item item = InitItem();

            for (Item i = item; i != null; i=i.Child)
            {
                Console.WriteLine(i.Value);
            }
        }

        static Item InitItem ()
        {
            return new Item
            {
                Value = 5,
                Child = new Item()
                {
                    Value = 10,
                    Child = new Item()
                    {
                        Value = 2
                    }
                }
            };
        }
    }
    class Item
    {
        public int Value { get; set; }
        public Item Child { get; set; }
    }
}
