using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0._2_Dictionary__HashSet__Stack__Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary команды
            // ключ,значение
            // Add - Добавляет ключ,значение в словарь
            // Count - Возвращает число "пар-ключей",содержащихся в словаре
            // Clear - Удаляет все ключи и значения из словаря
            // [] - Возвращает или задает значение,связанно с указанным ключом
            // ContainsKey - Определяет,содержится ли указанный ключ в словаре
            // Remove - Удаляет значение с указанным ключом из словаря
            // Keys - Возвращает коллекцию,содержащую ключи из словаря
            // Values - Возвращает коллекцию,содержащую значение из словаря
            // KeyValuePait<string,string>
            #endregion

            #region Пример со словарем
            ////          ключ  значение
            //Dictionary<string, string> pairs = new Dictionary<string, string>();
            //pairs.Add("Учитель", "Teacher");
            //pairs.Add("Ученик", "Student");

            //// Вывод всех пар

            //foreach (KeyValuePair<string,string> e in pairs)
            //{
            //    Console.WriteLine(e);
            //}

            //// Вывод ключа
            //Console.WriteLine(pairs["Учитель"]);
            //Console.WriteLine();

            //// Вывод всех ключей
            //foreach (var e in pairs.Keys)
            //{
            //    Console.WriteLine(e);
            //}

            //Console.WriteLine();

            //// Вывод всех значений
            //foreach (var e in pairs.Values)
            //{
            //    Console.WriteLine(e);
            //}

            //Console.WriteLine();

            //// Удаление по ключу
            //pairs.Remove("Учитель");
            //foreach (var item in pairs)
            //{
            //    Console.WriteLine(item);
            //}

            //// Проверка на содержание значения по ключу в словаре
            //Console.WriteLine();

            //Console.WriteLine(pairs.ContainsKey("Учитель"));

            //// Колличество элементов в словаре
            //Console.WriteLine();
            //Console.WriteLine(pairs.Count);

            #endregion



            #region Queue Команды !Позволяет обрабатывать данные в порядке их добавления!
            // Enqueue - Добавляет обьект в конец очереди
            // Dequeue - Удаляет обьект из начала очереди и возвращает его
            // Peek - Вовзращает обьект, находящийся в начале очереди, но не удаляет его
            // Count -  Получает число элементов, содержащихся в очереди
            // Clear - Удаляет все обьекты из очереди   
            // First In First Out = FIFO

            #endregion

            #region Пример
            //Queue<int> queue = new Queue<int>();

            //// Enqueue - Добавляет обьект в конец очереди

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //foreach (var e in queue) Console.Write($"{e} "); // 1 2 3 4 5
            //Console.WriteLine("\n");

            //// Dequeue - Удаляет обьект из начала очереди и возвращает его

            //Console.WriteLine($"queue.Dequeue() = {queue.Dequeue()}"); // 1
            //foreach (var e in queue) Console.Write($"{e} "); // 2 3 4 5
            //Console.WriteLine("\n");

            //// Peek - Вовзращает обьект, находящийся в начале очереди, но не удаляет его

            //Console.WriteLine($"queue.Peek() = {queue.Peek()}"); // 2
            //foreach (var e in queue) Console.Write($"{e} "); // 2 3 4 5
            //Console.WriteLine("\n");

            #endregion


            #region Stack Команды
            // Firs In Last OUT
            // Push - Вставляет обьект как верхний элемент стека
            // Pop - Вовзращает обьект в верхней части без его удаления 
            // Peek - Возвращает обьект в верхней части стека без его удаления
            // Count - Получает число элементов, содержащихся в стеке
            // Clear - Удаляет все обьекты из стека
            #endregion

            #region Пример
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //foreach (var e in stack) Console.Write($"{e} ");// 5 4 3 2 1
            //Console.WriteLine("\n");

            //Console.WriteLine($"stack.Pop = {stack.Pop()}"); // 5
            //foreach (var e in stack) Console.Write($"{e} ");// 4 3 2 1
            //Console.WriteLine("\n");

            //Console.WriteLine($"stack.Peek = {stack.Peek()}"); // 4
            //foreach (var e in stack) Console.Write($"{e} ");// 4 3 2 1
            //Console.WriteLine("\n");



            #endregion


            #region HashSet Команды
            // Add - Добавляет указанный элемент в коллекцию
            // Remove - Удаляет указанный элемент из коллекцию
            // Contains - Определяет, содержит ли указанный элемент
            // UnionWith - Изменяет текущий обьект так, чтобы он содержал все элементы,
            //             имеющиеся в нем или в указанной коллекции либо как в нем , так и в указанной коллекции
            // IntersectWith - Изменяет текущий обьект так, чтобы он содержал только элементы,
            //                 которые имеются в этом обьекте и в указанной коллекции
            // ExceptWith - Удаляет все элементы в указанной коллекции из текущего обьекта
            // IsSubsutOf - Определяет, является ли обьект подмножеством указанной коллекции
            // IsSuperSetOf - Определяет, является ли обьект супермножеством указанной коллекции
            // IsProperSubsetOf - Определяет, является ли обьект строгим подмножеством указанной коллекции
            // IsProperSupersetOf - Определяет, является ли обьект строгим супермножеством указанной коллекции
            #endregion

            #region Пример
            HashSet<int> set1 = new HashSet<int>(new int[] { 1, 1, 1, 1, 1, 1, 1, 2, 3, 4, 5 });
            Console.WriteLine("set1: ");

            foreach (var e in set1) { Console.Write($"{e} "); }

            Console.WriteLine($"\n\nЭлемент '3' Присутствует в set1: {set1.Contains(3)}");
            Console.WriteLine($"\n\nЭлемент '20' Присутствует в set1: {set1.Contains(20)}\n");

            Console.WriteLine("set2: ");

            HashSet<int> set2 = new HashSet<int>(new int[] { 1, 3, 5, 7, 9, 11, 15 });
            foreach (var e in set2) { Console.Write($"{e} "); }

            set1.UnionWith(set2);

            Console.WriteLine("\n\nset1 после UnionWith: ");
            foreach (var e in set1) { Console.Write($"{e} "); }

            set1.ExceptWith(new int[] { 3, 5, 15 });
            Console.WriteLine("\n\nset1 после ExceptWith(new int[] { 3, 5, 15 }): ");
            foreach (var e in set1) { Console.Write($"{e} "); }

            #endregion


            #region Other
            // using System.Collections.SortedSet;
            // using System.Collections.SortedList;
            // using System.Collections.SortedDictionary;
            #endregion


            #region Создать частотный словарь
            //Random r = new Random();
            //List<int> list = new List<int>();

            //for (int i = 0; i < 1000; i++)
            //{
            //    list.Add(r.Next(20));
            //}

            //Dictionary<int,int> dictionary = new Dictionary<int, int>();

            //foreach (var e in list)
            //{
            //    if (!dictionary.ContainsKey(e))
            //    {
            //        dictionary.Add(e,0);
            //    }
            //    dictionary[e]++;
            //}

            //foreach (var e in dictionary)
            //{
            //    Console.WriteLine($"Элемент: {e.Key} повторялся: {e.Value} раз");
            //}
            #endregion





        }
    }
}
