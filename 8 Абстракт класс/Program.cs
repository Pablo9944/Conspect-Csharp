using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Абстракт_класс
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    
        abstract class ComputerPart
        {
            public abstract string Name
            {
                get;
                set;
            }
            public abstract void Work();
            public void Test ()
            {

            }
        }

        class Processor : ComputerPart
        {
            private string name;
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public override void Work() { }
        }

        class MotherBoard : ComputerPart
        {
            private string name;
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public override void Work() { }
        }

        class GraphicCard : ComputerPart
        {
            public override string Name
            {
                get;
                set;
            }
            public override void Work() { }
        }
    }
}
