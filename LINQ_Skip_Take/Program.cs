
class Program
{
    static void Main()
    {
        // Skip - Для пропуска элементов существует метод
        // Take - Для включения элементов в выборку 

        //var cars = new[] { "Volvo", "Opel", "Suzuki", "Toyota", "Lada", "Kamaz" };

        //// пропустим первые два элемента
        //var skip2 = cars.Skip(2);

        //foreach (var car in skip2)
        //    Console.WriteLine(car);

        //Console.WriteLine();

        //// пропустим первые два элемента и выведем следующие два
        //var skip3 = cars.Skip(2).Take(2);

        //foreach (var car in skip3)
        //    Console.WriteLine(car);


        var contacts = new List<Contact>()
        {
           new Contact() { Name = "Андрей", Phone = 7999945005 },
           new Contact() { Name = "Сергей", Phone = 799990455 },
           new Contact() { Name = "Иван", Phone = 79999675 },
           new Contact() { Name = "Игорь", Phone = 8884994 },
           new Contact() { Name = "Анна", Phone = 665565656 },
           new Contact() { Name = "Василий", Phone = 3434 }
        };

        while (true)
        {
            Console.Write("Введите число: ");
            
            IEnumerable<Contact> result = null;

            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    Console.WriteLine();
                    result = contacts.Take(2);
                    break;
                    case '2':
                    Console.WriteLine();
                    result = contacts.Skip(2).Take(2);
                    break;
                    case '3':
                    Console.WriteLine();
                    result = contacts.Skip(4);
                    break;
                default: 
                    Console.WriteLine("\nCписок пуст"); continue;

               
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} {item.Phone}");
            }
        }
    }
    class Contact
    {
        public string Name { get; set; }
        public long Phone { get; set; }
    }
}
