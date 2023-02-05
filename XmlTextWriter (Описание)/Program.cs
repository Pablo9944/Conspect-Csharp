using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlTextWriter__Описание_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // если не указывать xmlWriter.WriteEndElement(); то элементы будут в одну строку

            // Создаем Xml файл
            XmlTextWriter writer = new XmlTextWriter("books.xml",null);
            writer.WriteStartDocument();  // Заголовок XML - <?xml version="1.0"?>
            writer.WriteStartElement("ListOfBooks");  // Корневой элемент - <ListOfBooks>
            writer.WriteStartElement("Book");         // Книга 1  - <Book>
            writer.WriteStartAttribute("FontSize");   // Attribute - FontSize
            writer.WriteString("8");                  // = 8
            writer.WriteEndAttribute();               // >
            writer.WriteString("Title-1");            // Title-1
            writer.WriteComment("Coment");           // Comment
            writer.WriteEndElement();                 // </Book>
            writer.WriteEndElement();                 // </LisrOfBooks>
            writer.Close();

        }
    }
}
