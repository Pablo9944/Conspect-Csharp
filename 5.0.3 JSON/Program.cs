using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5._0._1_XML__Создание_и_чтение_файлов_;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace _5._0._3_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Для работы необходимо скачать Istall-Package Newtonsoft.Json  -Version 10.0.3
            // Средства => Диспетчер пакетов Nugget => Консоль диспетчеров пакета => вводим в консоль Install-Package Newtonsoft.Json -Version 10.0.3
            // Добавляем using Newtonsoft.Json
            //           using Newtonsoft.Json.Linq;

            #region Сериализаци и Десириализация Json


            //Worker worker = new Worker("Pablo","Yurov","C#",500000,"Yandex");
            //worker.Print();
            
            
            //string json = JsonConvert.SerializeObject(worker);
            //File.WriteAllText(@"F:\5_0_3.json", json);

            //Console.WriteLine();


            //json = File.ReadAllText(@"F:\5_0_3.json");

            //worker = JsonConvert.DeserializeObject<Worker>(json);
            //worker.Print();

            //List<Worker> list = new List<Worker>();

            //for (int i = 1; i < 5; i++)
            //{
            //    list.Add(new Worker { FirstName = $"Имя_{i}", LastName = $"Фамилия{i}", Position = $"Должность_{i}", Salary = 500000, Departament = $"Департамент{i}" });
            //}

            //json = JsonConvert.SerializeObject(list);
            //File.WriteAllText(@"F:\list.json", json);

            //json = File.ReadAllText(@"F:\list.json");
            //list = JsonConvert.DeserializeObject<List<Worker>>(json);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.FirstName + item.LastName + item.Position + item.Salary + item.Departament);
            //}

            // Коллекция коллекций
            List<List<int>> list2 = new List<List<int>>();

            #endregion

            #region Parse
            string json = File.ReadAllText(@"F:\5_0_3.json");
            Console.WriteLine(json);


            Console.WriteLine(JObject.Parse(json)["FirstName"].ToString());

            #endregion

            #region Create
            JArray array = new JArray();
            
            //Узел
            JObject mainTree = new JObject();


            mainTree["ok"] = true;
            JObject o = new JObject();
            o["update_id"] = 666;
            o["message_id"] = 777;

            array.Add(o);
            array.Add(o);
            array.Add(o);

            // по ключу message храним массив значений
            mainTree["message"] = array;
            JObject userObj = new JObject();
            userObj["id"] = 123123;
            userObj["firstname"] = "Test";
            userObj["username"] = "test";

            mainTree["user"] = userObj;

            File.WriteAllText(@"F:\jsonCreate.json", mainTree.ToString());


            #endregion

            #region Пример
            List<Worker> list = new List<Worker>();  
            JObject data = new JObject();
            JArray Myarray = new JArray();

            for (int i = 1; i < 6; i++)
            {
                JObject obj = new JObject();
                obj["Firstname"] = $"Имя_{i}";
                obj["LastName"] = $"Фамиля_{i}";
                obj["Position"] = $"Должность_{i}";
                obj["Salary"] = $"Зарплата{i*10000}";
                obj["Department"] = $"Департамент_{i}";

                Myarray.Add(obj);   
            }

           


            File.WriteAllText(@"F:\Пример.json", Myarray.ToString());


            #endregion
        }
    }
}
