using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._2_HomeWork__SkillBox___OOP_
{
    class Client
    {
        internal string Name { get; set; }
        internal string SurName { get; set; }
        internal string SecondName { get; set; }
        internal string Mobile { get; set; }
        internal string Document { get; set; }

        internal Client()
        {
            Name = "Иван";
            SurName = "Иванов";
            SecondName = "Иванович";
       
            if (Mobile == null)
            {
                Mobile = "777";
            }

            Document = "4517 567829";

        }

    }

    class Consultant
    {
        protected Client client;

        public Consultant(Client client)
        {
            this.client = client;
            client.Document = "********";
        }

        protected void PrintName() { Console.WriteLine(client.Name); }
        protected void PrintSurName() { Console.WriteLine(client.SurName); }
        protected void PrintSecondName() { Console.WriteLine(client.SecondName); }
        protected void PrintMobile() { Console.WriteLine(client.Mobile); }
        protected void PrintDocument() { Console.WriteLine(client.Document); }


    }

    class Manager : Consultant
    {
       
        public Manager(Client client) : base(client)
        {
            this.client = client;
        }
        


        
    
    
    }



}
