using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Missoin___Struct_и_их_разновидности
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook note_1 = new Notebook("MagicBook", "Honor", 30000);
            note_1.Show();

            Notebook n = new Notebook();
            n.Show();

        }
    }
}
