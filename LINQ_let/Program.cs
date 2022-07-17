
class Program
{
    static void Main()
    {
        // let -Довольно часто бывает, что при формировании запросов LINQ нам необходимо выполнять промежуточные вычисления.
        // Для этого LINQ поддерживает объявление промежуточных переменных по ключевому слову let.

        // Наш список студентов
        //List<Student> students = new List<Student>
        //{
        //   new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //   new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
        //   new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
        //   new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
        //};

        //var fullNameStudents = from s in students
        //                           // временная переменная для генерации полного имени
        //                       let fullName = s.Name + " Иванов"
        //                       // проекция в новую сущность с использованием новой переменной
        //                       select new
        //                       {
        //                           Name = fullName,
        //                           Age = s.Age
        //                       };

        //foreach (var stud in fullNameStudents)
        //    Console.WriteLine(stud.Name + ", " + stud.Age);

        // Наш список студентов
        List<Student> students = new List<Student>
        {
            new Student { Name = "Андрей", Age = 23, Languages = new List<string> { "английский", "немецкий" } },
            new Student { Name = "Сергей", Age = 27, Languages = new List<string> { "английский", "французский" } },
            new Student { Name = "Дмитрий", Age = 29, Languages = new List<string> { "английский", "испанский" } },
            new Student { Name = "Василий", Age = 24, Languages = new List<string> { "испанский", "немецкий" } }
        };

        var studentsYoungs = from s in students
                             where s.Age < 27
                             let BurnData = DateTime.Now.Year - s.Age
                             select new Application()
                             {
                                 YearOfBirth = BurnData,
                                 Name = s.Name
                             };

        foreach (var item in studentsYoungs)
        {
            Console.WriteLine(item.Name +" " + item.YearOfBirth);
        }




}
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public List<string> Languages { get; set; }
    }
    public class Application
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
    }
}