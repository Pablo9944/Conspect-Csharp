﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class SportsCar : Car
    {
        public SportsCar() { }

        public SportsCar(string name, short maxSpeed, short currentSpeed)
            : base(name, maxSpeed, currentSpeed)
        {
        }

        public override void Acceleration()
        {
            Console.WriteLine("SPORTCAR:  Быстрая скорость!");
        }
    }

    internal class SecretCar : Car
    {
        public override void Acceleration()
        {
            throw new NotImplementedException();
        }
    }
}
