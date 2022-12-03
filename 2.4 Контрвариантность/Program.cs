using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Контрвариантность
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new BMW("X6");
            IGarage<BMW> garage = new Garage<Car>(car);
            garage.ToString();
            
            

            
        }
    }
    abstract class Car
    {
       
      
    }
    class BMW : Car
    {

        public string Model { get; set; }
        public BMW(string model) 
        {
            Model = model;
        }
    }

    class Garage<T> : IGarage<T>
    {
        private T carPlace;

        public T Carplace
        {
            set
            {
                carPlace = value;
            }
        }

        

        public Garage(T car)
        {
            this.carPlace = car;
        }
        //public override string ToString()
        //{
        //    return carPlace.ToString();
        //}
    }

    interface IGarage<in T>
    {
        T Carplace { set; }
    }
}
