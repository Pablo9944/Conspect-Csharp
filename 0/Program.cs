using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCollection my = new MyCollection();
            my[0] = new ElementMyCollection(1, 2);
            my[1] = new ElementMyCollection(3, 4);
            my[2] = new ElementMyCollection(5, 6);
            my[3] = new ElementMyCollection(7, 8);

     

            foreach (var e in my)
            {
                if (e is ElementMyCollection myelement)
                {
                    Console.WriteLine(myelement.value_one + " " + myelement.value_two);
                }
            }

            Console.WriteLine(new string('=',20));

            // Так работает foreach

            IEnumerator ie = (my as IEnumerable).GetEnumerator();

            while (ie.MoveNext())
            {
                ElementMyCollection myelement = ie.Current as ElementMyCollection;
                Console.WriteLine(myelement.value_one + " " + myelement.value_two);
            }


        }
    }
   public class MyCollection : IEnumerable, IEnumerator
    {
       ElementMyCollection[] elements = new ElementMyCollection[4];
        int position = -1;

        public ElementMyCollection this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        object IEnumerator.Current => elements[position];
      
      

         bool IEnumerator.MoveNext()
        {
            if (position < elements.Length -1)
            {
                position++;
                return true;
            }
           ((IEnumerator)this).Reset();
            return false;
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }



    }
   public class ElementMyCollection
    {
        public int value_one;
        public int value_two;
        public ElementMyCollection(int value_one,int value_two)
        {
           this.value_one = value_one;
           this.value_two = value_two;
        }

    }
}
