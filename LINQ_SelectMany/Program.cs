
class Program
{
    static void Main()
    {
        // SelectMany — метод расширения, предоставляющий другой способ сделать сложную фильтрацию. 

        // Подготовим данные
       List<Student> students = new List<Student>
        {
           new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
           new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
           new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
           new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
        };

        // Составим запрос ()
        var selectedStudents = students.SelectMany(
               // коллекция, которую нужно преобразовать
               s => s.Languages,
               // функция преобразования, применяющаяся к каждому элементу коллекции
               (s, l) => new { Student = s, Lang = l })
           // дополнительные условия                          
           .Where(s => s.Lang == "английский" && s.Student.Age < 28)
           // указатель на объект выборки
           .Select(s => s.Student);

        // Выведем результат
        foreach (Student student in selectedStudents)
            Console.WriteLine($"{student.Name} - {student.Age}");

        Console.WriteLine();

        var companies = new Dictionary<string, string[]>();

        companies.Add("Apple", new[] { "Mobile", "Desktop" });
        companies.Add("Samsung", new[] { "Mobile" });
        companies.Add("IBM", new[] { "Desktop" });

        var result = from c in companies
                     where c.Value.Contains("Mobile")
                     select c;
        foreach (var item in result)
        {
            Console.WriteLine(item.Key);
        }

        Console.WriteLine();

        var numsList = new List<int[]>()
        {
           new[] {2, 3, 7, 1},
           new[] {45, 17, 88, 0},
           new[] {23, 32, 44, -6},
        };

        var result2 = numsList.SelectMany(s => s).OrderBy(s => s);
        foreach (var item in result2)
        {
            Console.WriteLine(item);
        }




    }

}

class Student
{
    
    public string Name { get; set; }
    public int Age { get; set; }

    public List<string> Languages { get; set; }
    //public Student(string Name, int Age, List<string> Languages)
    //{
    //    this.Name = Name;
    //    this.Age = Age;
    //   this.Languages = Languages;


    //}
}