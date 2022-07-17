
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

       // Сортировка по имени и возрасту (возрастание)
        var sortedStuds = students
                           .OrderBy(s => s.Name)
                           .ThenBy(s => s.Age);

        foreach (var stud in sortedStuds)
            Console.WriteLine(stud.Name + ", " + stud.Age);

        Console.WriteLine();
        // И по убыванию:

        var sortedStudsDesc = students
                           .OrderByDescending(s => s.Name)
                           .ThenByDescending(s => s.Age);

        foreach (var stud in sortedStudsDesc)
            Console.WriteLine(stud.Name + ", " + stud.Age);
    }
}
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Languages { get; set; }
}