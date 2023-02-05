using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _003_EndInvoke
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                Func<int, int, int> myDelegate = new Func<int, int, int>(Sum);

                // Первые 2 аргумента - аргументы метода Sum(1, 2).
                IAsyncResult asyncResult = myDelegate.BeginInvoke(1, 2, null, null);

                // Получение результата асинхронной операции.
                int result = myDelegate.EndInvoke(asyncResult);

                Console.WriteLine("Результат = " + result);

                // Delay
                Console.ReadKey();
            
            // Метод для выполнения в отдельном потоке.
          
        }
        static int Sum(int a, int b)
        {
            Thread.Sleep(2000);
            return a + b;
        }
    }
}
