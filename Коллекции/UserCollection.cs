using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Коллекции
{
    public class UserCollection : IEnumerable, IEnumerator
    {

        private Element[] _elementsArray;
        public UserCollection()
        {
            _elementsArray = new Element[4];
            _elementsArray[0] = new Element("A", 1, 10);
            _elementsArray[1] = new Element("B", 2, 20);
            _elementsArray[2] = new Element("C", 3, 30);
            _elementsArray[3] = new Element("D", 4, 40);
        }

        // Указатель текущей позиции элемента в массиве
        private int position = -1;

       

        // Реализация IEnumerator

        // Передвинуть внутренний указатель (position) на одну позицию
        public bool MoveNext()
        {
            if (position < _elementsArray.Length -1)
            {
                position++;
                return true;
            }
            return false;
        }

        // Установить указатель (position) перед началом набора
        public void Reset()
        {
            position = -1;
        }
        // Получить текущий элемент набора.
        public object Current => _elementsArray[position];

        // Реализация интерфейса - IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;  
        }
    }

}
