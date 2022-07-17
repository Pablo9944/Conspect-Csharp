﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _5.События
{
    internal class Car
    {
        public static event Action<string, int> CreateCar;

        private static int count;
        private static Random random;

        static Car()
        {
            count = 0;
            random = new Random();
        }

        public string Mark { get; set; }
        public string Model { get; set; }
        public double Engine { get; set; }

        public Car(string Mark, string Model, double Engine)
        {
            this.Mark = Mark;
            this.Model = Model;
            this.Engine = Engine;

            count++;

            Thread.Sleep(random.Next(1000, 3000));

            //CreateCar($"Car сошёл с конвеера в {DateTime.Now.ToShortTimeString()}. Параметры {Mark} {Model} {Engine}",
            //    count);

            CreateCar?.Invoke($"Car создан в {DateTime.Now.ToShortTimeString()}. Параметры {Mark} {Model} {Engine}",
                count);
        }

        public override string ToString()
        {
            return $"{this.Mark} {this.Model} {this.Engine}";
        }
    }
}
