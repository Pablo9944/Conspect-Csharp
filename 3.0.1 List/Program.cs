using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3._0._1_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Список команд для List
            // Add - Добавляет обьет в конец
            // AddRange - Добавляет элементы  указанной коллекции в конец списка
            // Remove - Удаляет первохое вхождение указанного обьекта из коллекции
            // RemoveAt - Удаляет элемент списка с указанным индексом
            // Contains - Определяет,входит ли элемент в коллекцию
            // IndexOf - Осуществляет поиск указанного обьекта и возвращает отсчитываемый от нуля индекс
            //           первого вхождения ,найденного в пределах всего списка
            // LastIndexOf - Осуществляет поиск указанного обьекта возвращает отсчитываемый от нуля индекс
            //           последнего вхождения, найденного в пределах всего списка
            // [] - Возвращает или задает элемент по указанному индексу
            // Insert - Вставляет элемент в коллекцию по указанному индексу
            // Count - Получает число элементов,содержащихся в коллекции
            // Clear - Удаляет все элементы в коллекции
            // Сортировка списка
            // Sort или Sort(функция_сравнения)
            // Reverse 
            #endregion
            Random r = new Random();
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(11);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            for (int i = 0; i < list.Count; i++)
            {
                list.Sort();
                Console.WriteLine(list[i]);
            }

            



        }
    }
}
