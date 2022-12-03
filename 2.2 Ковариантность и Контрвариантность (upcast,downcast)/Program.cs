using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Ковариантность_и_Контрвариантность__upcast_downcast_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW bMW = new BMW("X6");
            IGarage<BMW> garage = new Garage<BMW>(bMW);
            Console.WriteLine(garage.Carplace.Model);

        }
    }


    abstract class Car { }
    class  BMW : Car
    {
        public string Model { get; set; }
        public BMW(string model)
        {
            Model = model;
        }
    }

    class Garage <T> : IGarage <T> 
    {
       public T Carplace { get; set; }


        public Garage(T car)
        {
            this.Carplace = car;
        }
    }
    
    interface IGarage <T> 
    {
         T Carplace { get; set; }
    }
}
