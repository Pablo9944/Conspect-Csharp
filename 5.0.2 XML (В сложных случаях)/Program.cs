using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace _5._0._2_XML__В_сложных_случаях_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Подлючаем using System.Xml.Linq;
            #region XDocument.Parse
            // считываем файл
            string xml = System.IO.File.ReadAllText(@"E:\SerList.xml");

            // Разбираем этот xml и доступаемся через дерево по веткам до FORECAST
            var col = XDocument.Parse(xml)
                               .Descendants("MMWEATHER")
                               .Descendants("REPORT")
                               .Descendants("TOWN")
                               .Descendants("FORECAST") // Получаем коллекцию FORECAST
                               .ToList();

            // Пробегаем по коллекции FORECAST и выводим все что там внутри блока
            foreach (var item in col)
            {
                Console.WriteLine($"\n\n{item}\n");
            }

            // Пробегаем по коллекции FORECAST и выводим значения атрибута day month year
            foreach (var item in col)
            {
                Console.WriteLine("day: {0} month: {1} year: {2}",
                    item.Attribute("day").Value,
                    item.Attribute("month").Value,
                    $"{item.Attribute("year").Value}\n");
            }

            // Пробегаем по коллекции FORECAST и выводим значения узла TEMPERATURE и его атрибута min max
            foreach (var item in col)
            {
                Console.WriteLine("min: {0} max: {1}",
                    item.Element("TEMPERATURE").Attribute("min").Value,
                    $"{item.Element("TEMPERATURE").Attribute("max").Value}\n");
            }

            // Получаем значение атрибута sname
            string city = XDocument.Parse(xml)
                               .Element("MMWEATHER")
                               .Element("REPORT")
                               .Element("TOWN")
                               .Attribute("sname").Value;

            Console.WriteLine($"\n{city}");
            #endregion

            #region XDocument.Create
            XElement myMMWEATHER = new XElement("MMWEATHER");
            XElement myTOWN = new XElement("TOWN");
            XElement myFORECAST = new XElement("FORECAST");
            XElement myTEMPERATURE = new XElement("TEMPERATURE");


            XAttribute xAttributeMin = new XAttribute("min", 7);
            XAttribute xAttributeMax = new XAttribute("max", 17);

            myTEMPERATURE.Add(xAttributeMin, xAttributeMax);
            myFORECAST.Add(myTEMPERATURE);

            XAttribute xAttributeCityName = new XAttribute("sname", "Moscow");
            myTOWN.Add(myFORECAST,xAttributeCityName);

            myMMWEATHER.Add(myTOWN);
            myMMWEATHER.Save(@"E:\CreateSec.xml");


            #endregion
        }
    }
}
