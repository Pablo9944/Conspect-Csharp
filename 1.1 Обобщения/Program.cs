using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Обобщения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dic = new Dictionary<int,string>();

            Temporary<double, int> t1 = new Temporary<double, int>(15.05, 777); t1.GetPropertyInformation();
            Temporary<string, bool> t2 = new Temporary<string, bool>("Hello", true); t2.GetPropertyInformation();
            Temporary<bool, double> t3 = new Temporary<bool, double>(false, 15.05); t3.GetPropertyInformation();
        
            
        
        }
    }
}
