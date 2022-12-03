
class Program
{
    static void Main()
    {
        // Подготовка данных
       var cars = new List<Car>()
        {
           new Car("Suzuki", "JP"),
           new Car("Toyota", "JP"),
           new Car("Opel", "DE"),
           new Car("Kamaz", "RUS"),
           new Car("Lada", "RUS"),
           new Car("Lada", "RUS"),
           new Car("Honda", "JP"),
        };

        Console.WriteLine("Пропустим японские машины в начале списка");
        var notJapanCars = cars.SkipWhile(car => car.CountryCode == "JP");

        foreach (var notJapanCar in notJapanCars)
            Console.WriteLine(notJapanCar.Manufacturer);

        Console.WriteLine();

        Console.WriteLine("Теперь выберем только японские машины из начала списка");
        var japanCars = cars.TakeWhile(car => car.CountryCode == "JP");

        foreach (var japanCar in japanCars)
            Console.WriteLine(japanCar.Manufacturer);

        Console.WriteLine();

       cars.RemoveAll(car => car.CountryCode == "JP");
        foreach (var item in cars)
        {
            Console.WriteLine(item.Manufacturer + " " + item.CountryCode );
        }

    }
}
public class Car
{
    public string Manufacturer { get; set; }
    public string CountryCode { get; set; }

    public Car(string manufacturer, string countryCode)
    {
        Manufacturer = manufacturer;
        CountryCode = countryCode;
    }
}