using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Mission__static_and_nested_
{
    internal class Book
    {
        Notes N = null;
     
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < N.notes.Length; i++)
                {
                    if (N.notes[i] == index)
                    {
                        return $"Есть такая заметка - {N.notes[i]} под пунктом {i} ";
                    }
                }
                return "s";
            }
        }

        public Book(Notes notes)
        {
            N = notes;
        }


        public class Notes 
        {
            public string[] notes;

            public Notes()
            {
                notes = new string[3];
                notes[0] = "1";
                notes[1] = "2";
                notes[2] = "3";
                
            }
        }
    }
}
