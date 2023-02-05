using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Форматирование_XmlDocument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter("books.xml", null);
            xmlWriter.Formatting = Formatting.Indented;

            // Для выделения уровня элемента использовать табуляцию
            xmlWriter.IndentChar = '\t';

            // Использовать один символ табуляции
            xmlWriter.Indentation = 5;

            // По умолчанию строки в XML файл записываются с помощью двойных кавычек.
            // Использование одиночных кавычек производится так:
            xmlWriter.QuoteChar = '\'';


            // если не указывать xmlWriter.WriteEndElement(); то элементы будут в одну строку
            xmlWriter.WriteStartDocument();  
            xmlWriter.WriteStartElement("ListOfBooks");  
            xmlWriter.WriteStartElement("ListOfBooks","http://localhost/test");         
            xmlWriter.WriteString("54321");
            xmlWriter.WriteStartElement("prefix", "ListOfBooks", "http://localhost/test");
            xmlWriter.WriteString("1234");
            

            xmlWriter.Close();

        }
    }
}
