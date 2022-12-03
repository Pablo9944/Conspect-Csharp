using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Обобщения
{
    internal class Temporary <Template1, Template2>
    {
        public Temporary(Template1 value1, Template2 value2)
        {
            Property1 = value1;
            Property2 = value2; 
        }


        public Template1 Property1 { get; set; }
        public Template2 Property2 { get; set; }


        public void GetPropertyInformation()
        {
            Console.WriteLine($"type: {Property1.GetType()} value: {Property1}");
            Console.WriteLine($"type: {Property2.GetType()} value: {Property2}");
        }
    }
}
