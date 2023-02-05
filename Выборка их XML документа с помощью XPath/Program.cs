using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Выборка_их_XML_документа_с_помощью_XPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XPathDocument document = new XPathDocument("books.xml");
            XPathNavigator navigator = document.CreateNavigator();

            // Прямой запрос XPath                                        //[2]
            XPathNodeIterator iterator1 = navigator.Select("ListOfBooks/Book/Title");

            foreach (var item in iterator1)
                Console.WriteLine(item);

            Console.WriteLine(new string('-',20));

            // Скомпилированный запрос XPath
            XPathExpression expr = navigator.Compile("ListOfBooks/Book/Price");
            XPathNodeIterator iterato2 = navigator.Select(expr);

            foreach (var item in iterato2)
                Console.WriteLine(item);

            Console.ReadKey();  
        }
    }
}
