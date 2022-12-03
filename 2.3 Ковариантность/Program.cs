using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Ковариантность
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW bMW = new BMW("X6");
            IGarage<Car> garage = new Garage<BMW>(bMW);
            Console.WriteLine(garage.Carplace.Carplace);

        }
    }
    abstract class Car 
    {
        public string Carplace { get; set; }
        public Car(string model)
        {
            Carplace = model;
        }
    }
    class BMW : Car
    {
       
        public string Model { get; set; }
        public BMW(string model): base (model)
        {
            Model = model;
        }
    }

    class Garage<T> : IGarage<T>
    {
        private T carPlace;

        public Garage(T car)
        {
            carPlace = car;
        }

        public T Carplace
        {
            get
            {
                return carPlace;
            }
        }
    }

    interface IGarage<out T>
    {
        T Carplace { get; }
    }
}
