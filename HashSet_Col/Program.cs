using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HashSet_Col
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Класс HashSet<T> поддерживает сохранение неупорядоченного списка уникальных элементов. 
             *Во всех случаях, когда вам нужна уникальность, но не важна упорядоченность элементов, с точки зрения производительности оптимально использовать именно его.
              HashSet<T> также способен автоматически изменять размер при добавлении/удалении элементов.
             */

            #region Пример
            // Создаем массив строк
            string[] names =  {
               "Игорь",   // повторяющееся значение
               "Андрей",
               "Васиий",
               "София",
               "Елена",
               "Анна",
               "Игорь"  //  повторяющееся значение
           };

            // Выведем длину массива в консоль
            Console.WriteLine("Длина массива " + names.Length);
            Console.WriteLine();
            Console.WriteLine("Данные в массиве");
            foreach (var n in names)
                Console.WriteLine(n);
            Console.WriteLine();

            // Создаем хэш-сет, передавая в конструктор наш массив
            HashSet<string> hSet = new HashSet<string>(names);
            // Посчитаем объекты в массиве
            Console.WriteLine("Длина хэш-сета " + hSet.Count);
            Console.WriteLine();
            // Выведем все элементы в консоль и посмотрим, есть ли дубликаты
            Console.WriteLine("Элементы в хэшсете:");
            foreach (var n in hSet)
                Console.WriteLine(n);
            #endregion

            #region Overlaps
            //Overlaps

            // Запускаем бесконечный цикл
            while (true)
            {
                Console.WriteLine("Введите текст:");

                // Сохраняем предложение в строку
                var sentence = Console.ReadLine();
                // сохраняем в массив char
                var characters = sentence.ToCharArray();

                var symbols = new HashSet<char>();

                // добавляем во множество. Сохраняются только неповторяющиеся символы
                foreach (var symbol in characters)
                    symbols.Add(symbol);

                // Выводим результат
                Console.WriteLine($"Всего {symbols.Count} уникальных символов");

                // сохраняем знаки препинания в массив Char
                var signs = new[] { ',', ' ', '.' };

                // сохраняем числовые символы в массив Char
                var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                //  Проверяем, есть ли цифры
                bool containsNumbers = symbols.Overlaps(numbers);
                Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");

                // Отбрасываем знаки препинания и заново считаем
                symbols.ExceptWith(signs);
                Console.WriteLine($"Символов без знаков препинания:: {symbols.Count}");

                Console.WriteLine();
                Console.WriteLine();
            }
                #endregion

                #region SymmetricExceptWith(otherCollection) 
                // SymmetricExceptWith(otherCollection) Специфичный метод. Изменяет HashSet<T> таким образом, чтобы он содержал только те элементы, которые есть в нём самом или otherCollection, исключая дубликаты на уровне обеих коллекций.

                var hSets = new HashSet<string>()
               {
                   "Иван", "Дмитрий"
               };

            hSet.SymmetricExceptWith(new[] { "Дмитрий", "Сергей", "Игорь" });

            Console.WriteLine("Элементы после объединения с новой коллекцией:");

            foreach (var n in hSets)
                Console.WriteLine(n);

            #endregion

            #region UnionWith() Продолжение Примера
            // UnionWith() Используется для объединения сета с другой коллекцией.
            hSet.UnionWith(new[] { "Дмитрий", "Сергей", "Игорь" });

            Console.WriteLine("Элементы после объединения с новой коллекцией:");

            foreach (var n in hSet)
                Console.WriteLine(n);
            #endregion

            #region ExceptWith(otherCollection) 
            //ExceptWith(otherCollection) Удаляет из хэш - сета все элементы, содержащиеся в другой коллекции.
            // Создадим два множества
            SortedSet<char> lettersOne = new SortedSet<char>();
            SortedSet<char> lettersTwo = new SortedSet<char>();

            //  Добавим элементы в первую
            lettersOne.Add('A');
            lettersOne.Add('B');
            lettersOne.Add('C');
            lettersOne.Add('Z');

            // выведем
            PrintCollection(lettersOne, "Первая коллекция: ");

            // Добавим элементы во вторую
            lettersTwo.Add('X');
            lettersTwo.Add('Y');
            lettersTwo.Add('Z');

            // выведем
            PrintCollection(lettersTwo, "Вторая коллекция");

            //  Выполним вычитание множеств
            lettersOne.ExceptWith(lettersTwo);

            // Выведем результат
            PrintCollection(lettersOne, "Результат вычитания");
        }

        static void PrintCollection(SortedSet<char> ss, string s)
        {
            Console.WriteLine(s);
            foreach (char ch in ss)
                Console.Write(ch + " ");
            Console.WriteLine("\n");
        }
        #endregion

    

    }

}



