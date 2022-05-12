using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace _12._2_бинарной_сериализации_и_десериализация
{
    // Описываем наш класс и помечаем его атрибутом для последующей сериализации   
    [Serializable]
    //class Pet
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public Pet(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //// объект для сериализации
            //var person = new Pet("Rex", 2);
            //Console.WriteLine("Объект создан");

            //BinaryFormatter formatter = new BinaryFormatter();
            //// получаем поток, куда будем записывать сериализованный объект
            //using (var fs = new FileStream("myPets.dat", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, person);
            //    Console.WriteLine("Объект сериализован");
            //}
            //// десериализация
            //using (var fs = new FileStream("myPets.dat", FileMode.OpenOrCreate))
            //{
            //    var newPet = (Pet)formatter.Deserialize(fs);
            //    Console.WriteLine("Объект десериализован");
            //    Console.WriteLine($"Имя: {newPet.Name} --- Возраст: {newPet.Age}");
            //}
            //Console.ReadLine();


            Contact user = new Contact("Name", 89652869944, "email");
            Console.WriteLine("Обьект создан");

            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("UserContact.dat", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, user);
                Console.WriteLine("Объект сериализован");

            }

            using (var fs = new FileStream("UserContact.dat", FileMode.OpenOrCreate))
            {
               Contact Usernew = (Contact)bf.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {Usernew.Name} --- Телефон: {Usernew.PhoneNumber} --- Email: {Usernew.Email}");
            }
            Console.ReadLine();



        }
    }
}