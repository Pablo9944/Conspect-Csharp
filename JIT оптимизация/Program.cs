using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*   
    Ключевое слово volatile можно применять к полям следующих типов:
    1. Ссылочные типы.
    2. Типы, такие как sbyte, byte, short, ushort, int, uint, char, float и bool.
    3. Тип перечисления с одним из следующих базовых типов: byte, sbyte, short, ushort, int или uint.
    4. Параметры универсальных типов, являющиеся ссылочными типами.
    
    Ключевое слово volatile можно применить только к полям класса или структуры.
    Локальные переменные не могут быть объявлены как volatile.

    Поля, помеченные ключевым словом volatile, не проходят оптимизацию компилятором. 
*/

namespace JIT_оптимизация
{
    internal class Program
    {
        static bool stop; // c JIT оптимизацией
       // static volatile bool stop; // БЕЗ JIT оптимизацией (Будет каждый раз проверятся условие)
        static void Main(string[] args)
        {
            Thread thread = new Thread(Function);
            thread.Start(); 

            Thread.Sleep(2000);

            stop = true;
            Console.WriteLine("Main ожидание завершения вторичного потокою");
            //thread.IsBackground= true;  
            thread.Join();   // Поток из Main ждёт выполнения другого потока
           Console.ReadLine();
        }
        static void Function()
        {
            int x = 0;
            while(!stop) 
            { 
                x++;
            }
            Console.WriteLine("Поток остановлен при x = {0}",x);
            /*   
               При компиляции данного кода JIT компилятор обнаружит, 
               что переменная stop не изменяется в методе Function.
               JIT Компилятор может создать код, заранее проверяющий условие цикла while,
               а переменная stop принимает участие в формировании условного выражения, 
               но при этом переменная stop не изменяется в методе Function - 
               следовательно оптимизатор делает предположение о том что условие статично,
               (оптимизатор не делает предположений о том что переменная может измениться из другого потока, 
               потому что  официально до определенного времени поток - был просто трюком - игрой с МС 8259А)
               Оптимизатор пытается угодить буферу предсказаний переходов CPU.

               ВНИМАНИЕ! 
               [Оптимизация не производиться в режиме отладки - DEBUG]
               [Если stop - volatile - то оптимизация JIT компилятором производиться не будет]
            */

            // Код метода после JIT оптимизации, если stop не volatile:
            //if (stop != true)
            //{
            //    Label:
            //    x++;
            //    goto Label;  // Оптимизация за счет чистого перехода без проверки условия.
            //}

            Console.WriteLine("Function: поток остановлен при x = {0}.", x);
        }
    }
}
