
class Program
{
    static void Main()
    {
        //// Список моделей
        //var cars = new List<Car>()
        //{
        //   new Car() { Model  = "SX4", Manufacturer = "Suzuki"},
        //   new Car() { Model  = "Grand Vitara", Manufacturer = "Suzuki"},
        //   new Car() { Model  = "Jimny", Manufacturer = "Suzuki"},
        //   new Car() { Model  = "Land Cruiser Prado", Manufacturer = "Toyota"},
        //   new Car() { Model  = "Camry", Manufacturer = "Toyota"},
        //   new Car() { Model  = "Polo", Manufacturer = "Volkswagen"},
        //   new Car() { Model  = "Passat", Manufacturer = "Volkswagen"},
        //};

        //        // Список автопроизводителей
        //var manufacturers = new List<Manufacturer>()

        //{
        //   new Manufacturer() { Country = "Japan", Name = "Suzuki" },
        //   new Manufacturer() { Country = "Japan", Name = "Toyota" },
        //   new Manufacturer() { Country = "Germany", Name = "Volkswagen" },
        //};

        //// Выборка + группировка
        //var result2 = manufacturers.GroupJoin(
        //   cars, // первый набор данных
        //   m => m.Name, // общее свойство второго набора
        //   car => car.Manufacturer, // общее свойство первого набора
        //   (m, crs) => new  // результат выборки
        //   {
        //       Name = m.Name,
        //       Country = m.Country,
        //       Cars = crs.Select(c => c.Model)
        //   });

        //// Вывод:
        //foreach (var team in result2)
        //{
        //    Console.WriteLine(team.Name + ":");

        //    foreach (string car in team.Cars)
        //        Console.WriteLine(car);

        //    Console.WriteLine();
        //}


        var departments = new List<Department>()
        {
            new Department() {Id = 1, Name = "Программирование"},
            new Department() {Id = 2, Name = "Продажи"}
        };

        var employees = new List<Employee>()
        {
            new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
            new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
            new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
            new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
        };

        var result = departments.GroupJoin(
            employees,
            d => d.Id,
            emp => emp.DepartmentId,
            (d, emp) => new
            {
                name = d.Name,
                employee = emp.Select(s=>s.Name)
            });

          

        
        foreach (var item in result)
        {
            Console.WriteLine(item.name);
            foreach (var e in item.employee)
            {
                Console.WriteLine(e);
            }
        }

        var customers = new Customer[]
{
       new Customer{ID = 5, Name = "Андрей"},
       new Customer{ID = 6, Name = "Сергей"},
       new Customer{ID = 7, Name = "Юлия"},
       new Customer{ID = 8, Name = "Анна"}
};

        var orders = new Order[]
        {
       new Order{ID = 6, Product = "Игру"},
       new Order{ID = 7, Product = "Компьютер"},
       new Order{ID = 3, Product = "Рубашку"} ,
       new Order{ID = 5, Product = "Книгу"}
        };

        var query = from c in customers
                    join o in orders on c.ID equals o.ID
                    select new { c.Name, o.Product };
        foreach (var group in query)
            Console.WriteLine($"{group.Name} покупает {group.Product}");
    }

}
// Модель автомобиля
public class Car
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }
}

// Завод - изготовитель
public class Manufacturer
{
    public string Name { get; set; }
    public string Country { get; set; }
}

class Department
{
    public int Id;
    public string Name;
}
class Employee
{
    public int DepartmentId;
    public string Name;
    public int Id;
}
class Customer
{
    public int ID { get; set; }
    public string  Name { get; set; }
}
class Order
{
    public int ID { get; set; }
    public string Product { get; set; }
}