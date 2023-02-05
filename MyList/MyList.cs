using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList__Mission_
{
    public class MyList<T> : IMyList<T>
    {
        T[] List;

        public MyList()
        {
            List = new T[0];
        }
        public T this[int index] => List[index];

        public int Count => List.Length;

        public void Add(T value)
        {
            T[] TempList = new T[List.Length + 1];
            for (int i = 0; i < List.Length; i++)
            {
                TempList[i] = List[i];
            }
            TempList[List.Length] = value;
            List = TempList;
        }

        public void Clear()
        {
            List = new T[0]; 
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < List.Length; i++)
            {
                if ((object)List[i] == (object)value)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
    public static class Arrays
    {
       internal static T[] GetArray<T>(this MyList<T> list)
        {
            T[] temp = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                temp[i] = list[i];
            }
            return temp;
        }
    }
}
