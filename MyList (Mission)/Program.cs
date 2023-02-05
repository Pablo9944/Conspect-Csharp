using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList__Mission_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> my_int = new MyList<string>();
            my_int.Add("1");
            my_int.Add("1");
            my_int.Add("1");

            Console.WriteLine(my_int.Contains("1"));

            for (int i = 0; i < my_int.Count; i++)
            {
                Console.WriteLine(my_int[i]);
            }

            my_int.GetArray();
           
            
            Console.WriteLine(my_int.Count);
        }
    }
  
}
