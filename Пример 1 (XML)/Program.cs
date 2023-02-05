using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Пример_1__XML_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stream stream = new FileStream("books.xml", FileMode.Open);

            using (XmlTextReader reader = new XmlTextReader(stream))
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0,-15} {1,-15} {2, -15}",
                                        reader.NodeType, reader.Name, reader.Value);
                   
                }
               
            }
            Console.WriteLine(new string('-',20));
            
            // Пример 2
            XmlDocument document = new XmlDocument();
            document.Load("books.xml");


            XmlNode root = document.DocumentElement;
            Console.WriteLine(root.LocalName);
            
            foreach (XmlNode c in root.ChildNodes)
            {
                foreach (XmlNode e in c.ChildNodes)
                {
                    Console.WriteLine(e.Name + ":" + e.InnerText);
                }
            }
        }
    }
}
