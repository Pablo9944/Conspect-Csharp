using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Check
{
    struct Repository
    {
        #region Поля
        public Worker[] workers;

        public Worker  this [int index]
        {
            get { return workers[index]; }
            set { workers[index] = value; }
        }

        public string path { get; set; }

        private int index;

        public string[] title { get; set; }


        #endregion

        #region Конструтор

        public Repository(string path)
        {
            this.path = path;
            this.index = 0;
            this.title = new string[5];
            this.workers = new Worker[2];
        }

        #endregion

        public void Add(Worker ConcreteWorker)
        {
            this.workers[index] = ConcreteWorker;
            this.index++;
        }

        public void AddTitle (string title,Worker worker)
        {
            this.title = title.Split(';');
            var args = worker;
            using (StreamWriter sw = new StreamWriter(path,true,Encoding.Default))
            {
                
            }
        }
      
      
        

    
        
    }






}
     
    


        
    

