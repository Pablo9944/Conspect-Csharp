using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Security.Policy;
using System.Collections;
using System.Threading;

namespace _666.Тестовая
{
    internal class Program
    {

        static void Main()
        {

            Console.WriteLine("Введите:");
          
            Func<Task<string>> f = new Func<Task<string>>(ConsoleReadLine);

            Console.WriteLine(f.BeginInvoke(null,null)); 

            
        } 
        static async Task<string> ConsoleReadLine()
        {
            string temp = "";
            Task.Delay(2000).Wait();
            await Task.Run(delegate
            {
                
                temp = Console.ReadLine();
                Console.WriteLine(temp);
            });
            return temp;
        }
    
    } 

   

}