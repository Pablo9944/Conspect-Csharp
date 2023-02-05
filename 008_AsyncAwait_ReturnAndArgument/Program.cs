using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _008_AsyncAwait_ReturnAndArgument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            

            Task<double> task = my.OperationAsync(3);

            task.ContinueWith(t => Console.WriteLine("Результат : {0}", t.Result));

            // Delay
            Console.ReadKey();
        }
    }
    class MyClass
    {
       public double Operation(object argument)
        {
            Thread.Sleep(2000);
            return (double)argument * (double)argument;
        }

        public async Task<double> OperationAsync(double argument)
        {
            return await Task<double>.Factory.StartNew(Operation, argument);
        }
    }
}
