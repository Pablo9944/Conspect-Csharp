using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Коллекции
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserCollection myCollection = new UserCollection();
            foreach (Element element in myCollection)
            {
                Console.WriteLine($"Name: {element.Name} Field1: {element.Field1} Filed2: {element.Field2}");
            }
            myCollection.Reset();
            Console.WriteLine(new string(' ',30));

            foreach (Element element in myCollection)
            {
                Console.WriteLine($"Name: {element.Name} Field1: {element.Field1} Filed2: {element.Field2}");
            }
            Console.WriteLine(new string(' ', 30) + "\n");


            // Так работает foreach
            UserCollection myElementsCollection = new UserCollection();

            // foreach - приводит коллекцию к интерфейсу типу IEnumerable
            IEnumerable enumerable = myElementsCollection as IEnumerable;

            // foreach - приводит коллекцию к интерфейсу типу вызывая метод - GetEnumeratore()
            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext()) // Перемещаем курсор на 1 шаг вперед (с -1 на 0) и т д
            {
                Element element = enumerator.Current as Element;
                Console.WriteLine($"Name: {element.Name} Field1: {element.Field1} Filed2: {element.Field2}");
            }

            enumerator.Reset();

        }
    }
}
