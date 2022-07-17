
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

        //// Список автопроизводителей
        //var manufacturers = new List<Manufacturer>()
        //{
        //   new Manufacturer() { Country = "Japan", Name = "Suzuki" },
        //   new Manufacturer() { Country = "Japan", Name = "Toyota" },
        //   new Manufacturer() { Country = "Germany", Name = "Volkswagen" },
        //};

        //var result = from car in cars // выберем машины
        //             join m in manufacturers on car.Manufacturer equals m.Name // соединим по общему ключу (имя производителя) с производителями
        //             select new //   спроецируем выборку в новую анонимную сущность
        //             {
        //                 Name = car.Model,
        //                 Manufacturer = m.Name,
        //                 Country = m.Country
        //             };

        //// выведем результаты
        //foreach (var item in result)
        //    Console.WriteLine($"{item.Name} - {item.Manufacturer} ({item.Country})");

        //var result2 = cars.Join(manufacturers, // передаем в качестве параметра вторую коллекцию
        //               car => car.Manufacturer, // указываем общее свойство для первой коллекции
        //               m => m.Name, // указываем общее свойство для второй коллекции
        //               (car, m) =>
        //                   new // проекция в новый тип
        //                   {
        //                       Name = car.Model,
        //                       Manufacturer = m.Name,
        //                       Country = m.Country
        //                   });

        //var departments = new List<Department>()
        //{
        //   new Department() {Id = 1, Name = "Программирование"},
        //   new Department() {Id = 2, Name = "Продажи"}
        //};
        //var employees = new List<Employee>()
        //{
        //   new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
        //   new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
        //   new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
        //   new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
        //};

        //var employeeAndDep = from employee in employees
        //                     join dep in departments on employee.DepartmentId equals dep.Id //  соединяем коллекции по общему ключу
        //                     select new // выборка в новую сущность
        //                     {
        //                         EmployeeName = employee.Name,
        //                         DepartmentName = dep.Name
        //                     };

        //foreach (var item in employeeAndDep)
        //    Console.WriteLine(item.EmployeeName + ", отдел: " + item.DepartmentName);

        //var employeeAndDep2 = employees.Join(departments, employee => employee.DepartmentId, n => n.Id, (employee, n) => new { EmployeeName = employee.Name, DepartmentName = employee.DepartmentId });
        //foreach (var item in employeeAndDep2)
        //{
        //    Console.WriteLine(item.EmployeeName + " " + item.DepartmentName);
        //}
    }
}
//// Модель автомобиля
//public class Car
//{
//    public string Model { get; set; }
//    public string Manufacturer { get; set; }
//}

//// Завод - изготовитель
//public class Manufacturer
//{
//    public string Name { get; set; }
//    public string Country { get; set; }
//}
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