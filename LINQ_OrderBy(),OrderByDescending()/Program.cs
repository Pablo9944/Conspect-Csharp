
class Program
{
    static void Main()
    {
            var students = new List<Student>
            {
               new Student {Name="Алёна", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Яков", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
               new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
               new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

        // Сортировка по возрасту
        var sortedStuds = from s in students
                          orderby s.Age
                          select s;

        foreach (var stud in sortedStuds)
            Console.WriteLine(stud.Name + ", " + stud.Age);

        Console.WriteLine();

        var sortedStuds2 = from m in students
                           orderby m.Age descending
                           select m;

        foreach (var stud in sortedStuds2)
            Console.WriteLine(stud.Name + ", " + stud.Age);

        Console.WriteLine();

        var result1 = sortedStuds.OrderBy(o => o.Age);
        foreach (var item in result1)
        {
            Console.WriteLine(item.Name + " " + item.Age);
        }

        Console.WriteLine();

        var result2 = students.OrderByDescending(o => o.Age);
        foreach (var item in result2)
        {
            Console.WriteLine(item.Name + " " + item.Age);
        }
    }
}
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Languages { get; set; }
}