using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_TPL_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен.");

            Task task = new Task(MyTask);

            try
            {
                task.Start();
                task.Wait(); // Для обработки исключения обязательно вызвать Wait!
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception       : " + ex.GetType());
                Console.WriteLine("Message         : " + ex.Message);

                if (ex.InnerException != null)
                    Console.WriteLine("Inner Exception : " + ex.InnerException.GetType());
            }
            finally
            {
                Console.WriteLine("Статус задачи   : " + task.Status);
            }

            Console.WriteLine("Основной поток завершен.");

            // Delay
            Console.ReadKey();
        }
        static void MyTask()
        {
            Console.WriteLine("Задача запущена.");

            throw new Exception();

            Console.WriteLine("Задача завершена.");
        }
    }
}
