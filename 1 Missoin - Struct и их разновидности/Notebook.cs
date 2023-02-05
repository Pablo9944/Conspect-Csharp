using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Missoin___Struct_и_их_разновидности
{
    public struct Notebook
    {
        readonly string model;
        readonly string producer;

        readonly int price;

        public string Model
        {
            get => model;
        }
        public string Producer
        {
            get => producer;
        }

        public int Price
        {
            get => price;
        }

        public Notebook(string model) : this (model,"",0)
        {
       
        }
        public Notebook(int price):this(" ", " ",price)
        {

        }
        public Notebook(string model,string producer,int price)
        {
            this.model = model;
            this.producer = producer;
            this.price = Math.Abs(price);
        }
       

        public void Show()
        {
            Console.WriteLine($"{model} - {producer} - {price}");
        }
    }
}
