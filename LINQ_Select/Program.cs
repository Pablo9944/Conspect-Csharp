
class Program
{
    static void Main()
    {
        // Select - Проекция позволяет преобразовать данные текущей выборки в какой-либо другой тип.

        //List<Student> students = new List<Student>
        //{
        //   new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //   new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
        //   new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
        //   new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
        //};

        //var names = from s in students select s.Name;

        //// Выведем результат
        //foreach (var name in names)
        //    Console.WriteLine(name);

        // Наш список студентов
        //List<Student> students = new List<Student>
        //{
        //   new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //   new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
        //   new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
        //   new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
        //};

        //var studentApplications = from s in students
        //                              // создадим анонимный тип для представления анкеты
        //                          select new
        //                          {
        //                              FirstName = s.Name,
        //                              YearOfBirth = DateTime.Now.Year - s.Age
        //                          };

        //foreach (var item in studentApplications)
        //{
        //    Console.WriteLine(item.FirstName + " " + item.YearOfBirth);
        //}

        // Наш список студентов
        List<Student> students = new List<Student>
        {
           new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
           new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
           new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
           new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
        };


        //var studentApplications = from s in students
        //                              // спроецируем в новую сущеность анкеты
        //                          select new Application()
        //                          {
        //                              FirstName = s.Name,
        //                              YearOfBirth = DateTime.Now.Year - s.Age
        //                          };
        //foreach (var item in studentApplications)
        //{
        //    Console.WriteLine(item.FirstName + " " + item.YearOfBirth);
        //}

        // выборка имен в строки
        var names = students.Select(u => u.Name);

        // проекция в анонимный тип
        var applications = students.Select(u => new
        {
            FirstName = u.Name,
            YearOfBirth = DateTime.Now.Year - u.Age
        });

        // проекция в другой тип
        var applications1 = students.Select(u => new Application()
        {
            FirstName = u.Name,
            YearOfBirth = DateTime.Now.Year - u.Age
        });

        string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

        var word = words.Select(s => new
        {
            Name = s,
            Length = s.Length
        }).OrderBy(m => m.Length);



    }
}
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public List<string> Languages { get; set; }
}
class Application
{
    public string FirstName { get; set; }
    public int YearOfBirth { get; set; }
}