using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DictionaryTKeyTValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.AddDictionary("1", "ss");

            Console.WriteLine(dic["1"]); 
        }
    }
}
