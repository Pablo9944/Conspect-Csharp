using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace _5._0._1_XML__Создание_и_чтение_файлов_
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Worker
            Worker worker = new Worker("Pavel", "Yurov", "C#", 150000, "PonyExpress");
           

            SerializeWorker(worker, @"E:\Ser.xml");

            worker = DeserializeWorker(@"E:\Ser.xml");

            worker.Print();



            #endregion

            #region List<Worker>
            List<Worker> list = new List<Worker>();
            for (uint i = 0; i <= 5; i++)
            {
                list.Add(new Worker($"Имя_{i}", $"Фамилия_{i}", $"Должность_{i}", i * 1000, $"Департамент_{i}"));
            }
            SerializeWorkerList(list, @"E:\SerList.xml");

            list = DeserializeWorkerList(@"E:\SerList.xml");

            worker.PrintList(list);

            #endregion
        }

        static void SerializeWorker (Worker ConcreteWorker, string Path)
        {
            
            // Создаем сериализатор на основе указанного типа
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));

            // Создаем поток для сохранения данных
            Stream fStream = new FileStream(Path, FileMode.Create,FileAccess.Write);

            // Запускам процесс сериализации
            xmlSerializer.Serialize(fStream, ConcreteWorker);

            // Закрываем поток
            fStream.Close();
        }
        static void SerializeWorkerList(List<Worker> tempList,string Path)
        {

            // Создаем сериализатор на основе указанного типа
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Worker>));

            // Создаем поток для сохранения данных
            Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);

            // Запускам процесс сериализации
            xmlSerializer.Serialize(fStream, tempList);

            // Закрываем поток
            fStream.Close();
        }
        static Worker DeserializeWorker(string Path)
        {
            Worker tempWorker = new Worker();

            // Создаем сериализатор на основе указанного типа
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));

            // Создаем поток для сохранения данных
            Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);

            // Запускам процесс десериализации
            tempWorker = xmlSerializer.Deserialize(fStream) as Worker;
            fStream.Close();
            return tempWorker;  
        }
        static List<Worker> DeserializeWorkerList(string Path)
        {
            List<Worker> tempList = new List<Worker>(); 

            // Создаем сериализатор на основе указанного типа
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));

            // Создаем поток для сохранения данных
            Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);

            // Запускам процесс десериализации
            tempList = xmlSerializer.Deserialize(fStream) as List<Worker>;
            fStream.Close();
            return tempList;
        }


    }
}
