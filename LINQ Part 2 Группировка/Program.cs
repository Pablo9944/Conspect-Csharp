
class Program
{
    static void Main()
    {
        #region Commands
        //GroupBy() - 
        #endregion

        #region GroupBy()
        var cars = new List<Car>()
        {
           new Car("Suzuki", "JP"),
           new Car("Toyota", "JP"),
           new Car("Opel", "DE"),
           new Car("Kamaz", "RUS"),
           new Car("Lada", "RUS"),
           new Car("Honda", "JP"),
        };

        // Пример 1
        //// Группировка по стране - производителю
        //var carsByCountry = from car in cars
        //                    group car by car.CountryCode;

        //// Пробежимся по группам
        //foreach (var grouping in carsByCountry)
        //{
        //    Console.WriteLine(grouping.Key + ":");

        //    // внутри каждой группы пробежимся по элементам
        //    foreach (var car in grouping)
        //        Console.WriteLine(car.Manufacturer);

        //    Console.WriteLine();

        // Пример 2
        //var result = cars
        //    .GroupBy(car => car.CountryCode) // группируем по стране-производителю
        //    .Select(group => new             // создаем новую сущность анонимного типа
        //    {
        //        Name = group.Key,
        //        Amount = group.Count()
        //    });

        //foreach (var c in result)
        //{
        //    Console.WriteLine(c.Name);
        //    foreach (var item in c.Amount.ToString())
        //    {
        //        Console.WriteLine(item);
        //    }

        //}

        // Пример 3
        //var carsByCountry2 = from car in cars
        //                     group car by car.CountryCode into grouping // выборка в локальную переменную для вложенного запроса
        //                     select new
        //                     {
        //                         Name = grouping.Key,
        //                         Count = grouping.Count(),
        //                         Cars = from p in grouping select p //  выполним подзапрос, чтобы заполнить список машин внутри нашего нового типа
        //                     };

        //// Выведем результат
        //foreach (var group in carsByCountry2)
        //{
        //    // Название группы и количество элементов
        //    Console.WriteLine($"{group.Name} : {group.Count} авто");

        //    foreach (Car car in group.Cars)
        //        Console.WriteLine(car.Manufacturer);

        //    Console.WriteLine();
        //}

        // Пример 4
       // var carsByCountry2 = cars
       //.GroupBy(car => car.CountryCode)
       //.Select(g => new
       //{
       //    Name = g.Key,
       //    Count = g.Count(),
       //    Cars = g.Select(c => c)
       //});

       // foreach (var item in carsByCountry2)
       // {
       //     Console.Write(item.Name + "-" );
     
       //     Console.WriteLine(item.Count);
       //     foreach (var c in item.Cars)
       //     {
       //         Console.WriteLine(c.Manufacturer);
       //     }
       //     Console.WriteLine();
            
           
       // }
        //}
        #endregion

        #region Задача
        var phoneBook = new List<Contact>();

        // добавляем контакты
        phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
        phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
        phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
        phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
        phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
        phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));
        #endregion

        var phoneBookTryEmail = from tryEmail in phoneBook
                                group tryEmail by tryEmail.Email into resultTryEmail
                                where !resultTryEmail.Key.Contains("example")
                                select new
                                {
                                    Email = resultTryEmail.Key
                                };

        var phoneBookNotTryEmail = phoneBook
                                    .GroupBy(notTryEmail => notTryEmail.Email)
                                    .Where(notTryEmail => notTryEmail.Key.Contains("example"))
                                    .Select(s => new
                                    {
                                        email = s.Key
                                    });

        foreach (var item in phoneBookNotTryEmail)
        {
            Console.WriteLine(item.email);
        }



        //foreach (var item in phoneBookTryEmail)
        //{
        //    Console.WriteLine(item.Email);
        //}
    }
}
class Car
{
    public string Manufacturer { get; set; }
    public string CountryCode { get; set; }
    public Car(string Manufacturer, string CountryCode)
    {
        this.Manufacturer = Manufacturer;
        this.CountryCode = CountryCode;
    }
}
class Contact
{
    public string Name { get; set; }
    public long Number { get; set; }
    public string Email { get; set; }
    public Contact(string name,long number,string email)
    {
        Name = name;
        Number = number;
        Email = email;
    }
}