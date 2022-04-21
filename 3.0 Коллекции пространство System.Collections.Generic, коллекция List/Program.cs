using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0_Коллекции_пространство_System.Collections.Generic__коллекция_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //bool result = RemoveAt(ref arr, 3);
            Arr r = new Arr(5);
            r.Add(666);
            r.RemoveAt(0);
            string s = r.Print();
            Console.WriteLine(s);
            
           
        }
    
        //static bool RemoveAt ( ref int[] Col , int position)
        //{
        //    bool result = false;
        //    if (position>=0 && position <= Col.Length )
        //    {
        //        for (int i = position; i < Col.Length-1; i++)
        //        {
        //            Col[i] = Col[i + 1];
        //        }
        //        Array.Resize(ref Col, Col.Length - 1);
        //        result = true;
                
        //    }

        //    else
        //    {
        //        result = false;
        //    }

        //    return true;
        //}
    
        
    }
}
