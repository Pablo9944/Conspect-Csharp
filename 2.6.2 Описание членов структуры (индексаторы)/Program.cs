using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6._2_Описание_членов_структуры__индексаторы_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Описание задачи
            /* Есть  struct Worker у ней 3 переменные Position,Salary,FirstName и конструток принимающий ( Position,Salary,FirstName) и метод Print() который выводит данные переменной
             * Мы создаем аля отдел под назаванием Repository1 struct и в рамках его всего лишь одна переменна - массив (public Worker[] Workers) и cоздаем конструктор Repository1 в качестве параметров принимает массив (params Worker[]Args) и пробрасывает данные в массив Workers.
             *Когда мы создаем экземляр класса Repository1 и называем db и в этот Repository1 в его конструткор передаем созданный экземпляр класса Worker (конструток которого принимает данные переменных Position,Salary,FirstName).
             *Как только переменные типа Worker заполняются мы переходим в конструктор Repository1, где он принимает params Worker[]Args и присваивает своей переменной public Worker[] Workers переменную Args.
             *Далее мы вызываем метод Print таким образом Console.WriteLine(db.Workers[0].Print; */
            #endregion
            // Развернутый вариант  Worker w1 = new Worker("Должность_1", 10000, "Имя_1");
            //   Repository1 db1 = new Repository1(w1);
            //Repository1 db = new Repository1(
            //    new Worker("Должность_1", 10000, "Имя_1"),   
            //    new Worker("Должность_2", 10000, "Имя_2"),
            //    new Worker("Должность_3", 10000, "Имя_3"),
            //    new Worker("Должность_4", 10000, "Имя_4"),
            //    new Worker("Должность_5", 10000, "Имя_5"));



            //for (int i = 0; i < db.Workers.Length; i++)
            //{
            //    Console.WriteLine(db.Workers[i].Print());
            //}

            //Repository2 db2 = new Repository2(
            //    new Worker("Должность_1", 10000, "Имя_1"),
            //    new Worker("Должность_2", 10000, "Имя_2"),
            //    new Worker("Должность_3", 10000, "Имя_3"),
            //    new Worker("Должность_4", 10000, "Имя_4"),
            //    new Worker("Должность_5", 10000, "Имя_5"));
 
            //Console.WriteLine(db2[0].Print());

            //db2[0] = new Worker("Программист", 700000, "Павел");
            //Console.WriteLine(db2[0].Print());



            //Repository3 db3 = new Repository3(
            //    new Worker("Должность_1", 10000, "Имя_1"),
            //    new Worker("Должность_2", 10000, "Имя_2"),
            //    new Worker("Должность_3", 10000, "Имя_3"),
            //    new Worker("Должность_4", 10000, "Имя_4"),
            //    new Worker("Должность_5", 10000, "Имя_5"));
            //Console.WriteLine(db3[3]);


            Repository4 db4 = new Repository4(
               new Worker("Должность_1", 10000, "Имя_1"),
               new Worker("Должность_2", 10000, "Имя_2"),
               new Worker("Должность_3", 10000, "Имя_3"),
               new Worker("Должность_4", 10000, "Имя_4"),
               new Worker("Должность_5", 10000, "Имя_5"));
            Console.WriteLine(db4["+"]);
            Console.WriteLine(db4[4] = 7);



        }
    }
}
