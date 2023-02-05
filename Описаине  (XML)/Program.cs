using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Описаине___XML_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("books.xml");
            Console.WriteLine(document.InnerText);
            Console.WriteLine(new string('-',20));

            Console.WriteLine(document.InnerXml);

           

        }
    }
}
