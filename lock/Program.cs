using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace @lock
{
   
    class MyClass
    {
        private object block = new object();
        public void Method()
        {
            int hash = Thread.CurrentThread.GetHashCode();
            lock (block)
            {
                for (int counter = 0; counter < 10; counter++)
                {
                    Console.WriteLine($"Поток # {hash}: шаг {counter} ");
                    Thread.Sleep(100);
                }
                Console.WriteLine(new string('-',20));
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                #region lock
                // lock - блокирует блок кода так, что в каждый момент времени, этот блок кода
                // сможет использлвать использовать только один поток. Все остальные потоки ждут пока текущий поток, закончит работу.
                #endregion

                Console.SetWindowSize(80, 40);
                MyClass instance = new MyClass();
                for (int i = 0; i < 3; i++)
                {
                    new Thread(instance.Method).Start();
                }
                Thread.Sleep(200);

            }
        }
    }
}
