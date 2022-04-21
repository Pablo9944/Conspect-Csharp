using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6._4_Инкапсуляция
{
    public struct Computer1
    {
        public string Title { get; set; }


        private bool condition;
        public int Indicator { get { return this.condition ? 1 : 0; } }
        
        public Computer1(string Title)
        {
            this.Title = Title;
            this.condition = false;
        }
   
        public void Power()
        {
            if (this.condition)
            {
                PowerOff();
                this.condition = false;
            }

            else
            {
                PowerOn();
                this.condition = true;
            }    
        }
    
        private void ActivationBios()
        {
            Console.WriteLine($"{this.Title} | Activation Bios.....");
        }

        private void ActivationOS()
        {
            Console.WriteLine($"{this.Title} | Activation OS.....");
        }

        private void Greeting()
        {
            Console.WriteLine($"{this.Title} | Hello");
        }

        private void DeactivationBIOS()
        {
            Console.WriteLine($"{this.Title} | Deactivation  BIOS.....");
        }

        private void DeactivationOS()
        {
            Console.WriteLine($"{this.Title} | Deactivation  OS.....");
        }
        private void Parting()
        {
            Console.WriteLine($"{this.Title} | Bye....");
        }

        public void Calculation()
        {
            Console.WriteLine($"\n{this.Title} | Calculation....\n");
        }

        public void PowerOn()
        {
            ActivationBios();
            ActivationOS();
            Greeting();
        }
    
        
        public void PowerOff()
        {
            DeactivationBIOS();
            DeactivationOS();
            Parting();
        }


    
    }
}
