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
            Worker worker = new Worker("Pavel","Yurov","C#",150000,"PonyExpress");
            Console.WriteLine(worker.Print());

            SerializeWorker(worker, @"D:\Ser.xml");



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
    
    }
}
