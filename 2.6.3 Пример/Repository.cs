using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2._6._3_Пример
{
     struct Repository
    {
        public Worker[] Workers;
       
        private string path;
        int index;
        string[] titles;
       
        public Repository(string path)
        {
            this.path = path;
            this.index = 0;
            this.titles = new string[5];
            this.Workers = new Worker[2];
        }
   
    
        private void Resize (bool flag)
        {
            Array.Resize(ref this.Workers, this.Workers.Length * 2);
        }
    
        public void Add (Worker ConcreteWorker)
        {
            this.Resize(index >= this.Workers.Length);
            this.Workers[index] = ConcreteWorker;
            this.index++;

        }
    
        public void Load()
        {
            using ( StreamReader st = new StreamReader(this.path,Encoding.Default))
            {
                titles = st.ReadLine().Split(';');
                

                while (!st.EndOfStream)
                {
                    string[]args = st.ReadLine().Split(';');
                    Add(new Worker(args[0], args[1], args[2], Convert.ToUInt32(args[3]),args[4]));
                    
                }
            }
        }
            
        public void PrintDbToCOnsole ()
        {
            Console.WriteLine($"{this.titles[0],15}{this.titles[1],15}{this.titles[2],15}{this.titles[3],15}{this.titles[4],15} ");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(this.Workers[i].Print());
            }
        }

        public int Count { get { return this.index; } }
    
    
    }
}
