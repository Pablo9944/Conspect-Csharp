using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Обобщения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Obj obj = new Obj();
            //obj.Display<int>(345);

            //int num1 = 4;
            //int num2 = 10;
            //Programs.Swap<int>(ref num1, ref num2);

            //Console.WriteLine("{0} {1}", num1, num2);

            //Console.ReadKey();
        }
    }

    abstract class Engine { }

    class ElectricEngine : Engine { }

    class GasEngine : Engine { }

    abstract class CarPart { }

    class Battery : CarPart { }

    class Differential : CarPart { }

    class Wheel : CarPart { }

    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }

    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    //class Generic<T1, T2, T3>
    //{
    //    public T1 Field; // Поле типа T1

    //    public T2 Property { get; set; } // Свойство типа T2

    //    public void Method(T3 param) // Параметр типа T3
    //    {

    //    }

    //    // Generic<object, int, string> generic = new Generic<object, int, string>();
    //}

    //class Record <T1,T2>
    //{
    //    public T1 id;
    //    public T2 Value;
    //    public DateTime Date;
    //}
    //class Obj
    //{
    //    public void Display<T>(T param)
    //    {
    //        Console.WriteLine(param.ToString());
    //    }
    //}
    //class Programs
    //{
    //    public static void Swap<T>(ref T x, ref T y)
    //    {
    //        T t = x;
    //        x = y;
    //        y = t;
    //    }
    //}
}
