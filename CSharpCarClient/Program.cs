using CarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCarClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем автомобиль спортивной модели.
            SportsCar sportcar = new SportsCar("Jaguar", 240, 40);
            sportcar.Acceleration();
            
            

            // Создаем мини-вэн.
            MiniVan minivan = new MiniVan();
            minivan.Acceleration();

            // Delay.
            Console.ReadKey();
        }
    }
}
