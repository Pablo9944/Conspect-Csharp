using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Статические_и_вложенные_классы
{
    static class FindAndReplaceManager
    {
        
        static string[] strBook;

        static FindAndReplaceManager()
        {
            Random r = new Random();

            string symbols = "ABCDEFGHSJJKOJHIUHIGCFHLKL123456789hjkdhjkp[kl,zvzxcvhcsdssaaxsaxas";

            strBook = new string[5];
            for (int i = 0; i < strBook.Length; i++)
            {
                strBook[i] = symbols.ToCharArray()[r.Next(0,symbols.Length)] + symbols.Substring(0,r.Next(2,symbols.Length)); 
            }
        }

        public static void FindNext(string str)
        {

        }
    }
}
