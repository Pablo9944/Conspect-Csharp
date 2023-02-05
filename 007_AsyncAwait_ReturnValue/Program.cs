using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _007_AsyncAwait_ReturnValue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyClass my = new MyClass();
            Task<int> task = my.OperationAsync();
            
            //Console.WriteLine(task.Result);
            task.ContinueWith(t => Console.WriteLine("Результат : {0}", t.Result));

            // Delay
            Console.ReadKey();
        }
    }
    class MyClass
    {
        int Operation()
        {
            Thread.Sleep(2000);
            return 2 + 2;
        }

        public async Task<int> OperationAsync()
        {
            //int result = await Task<int>.Factory.StartNew(Operation);
            //return result;

            return await Task<int>.Factory.StartNew(Operation);
        }
    }
}
