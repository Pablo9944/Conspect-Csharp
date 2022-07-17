
class Program
{
    static void Main()
    {
        #region Methods
        //Aggregate()-выполнение арифметического действия с элементами коллекции.
        //Count()-можно использовать, когда вы хотите не просто посчитать элементы, а  узнать, сколько из них удовлетворяют определенным критериям.
        #endregion

        #region Aggregate()
        //int[] numbers = { 1, 2, 3, 4, 5 };
        //int result = numbers.Aggregate((x, y) => x - y);

        //// вычислит 1-2-3-4-5 = -13
        //Console.WriteLine(result);
        #endregion

        #region Count()
        //students = new List<Students>();

        //students.Add(new Students { Name = "Pablo", Age = 24 });
        //students.Add(new Students { Name = "Alexander", Age = 23 });

        //// Вариант 1
        //// получим тех кто младше 25
        //var youngStudentsAmount =
        //   (from student in students
        //    where student.Age < 25
        //    select student).Count();

        //Console.WriteLine(youngStudentsAmount);


        //// Вариант 2

        //// получим тех, кто младше 25
        //youngStudentsAmount = students.Count(s => s.Age < 25);

        //Console.WriteLine(youngStudentsAmount);

        #endregion

        #region Count - Задача

        //var contacts = new List<Contact>()
        //{
        //   new Contact() { Name = "Андрей", Phone = 79994500508 },
        //   new Contact() { Name = "Сергей", Phone = 799990455 },
        //   new Contact() { Name = "Иван", Phone = 79999675334 },
        //   new Contact() { Name = "Игорь", Phone = 8884994 },
        //   new Contact() { Name = "Анна", Phone = 665565656 },
        //   new Contact() { Name = "Василий", Phone = 3434 }
        //};

        //var resultContacts = (from contact in contacts
        //                      let phoneString = contact.Phone.ToString()
        //                      where phoneString.StartsWith("7") && phoneString.Length == 11
        //                      select contact).Count();
        //Console.WriteLine(resultContacts);


        #endregion

        #region Sum() 
        //var students = new List<Student>
        //{
        //   new Student {Name="Андрей", Age=23 },
        //   new Student {Name="Сергей", Age=27 },
        //   new Student {Name="Дмитрий", Age=29 }
        //};

        //// сумма возрастов всех студентов
        //var totalAge = students.Sum(s => s.Age);

        //// Вернет 79
        //Console.WriteLine(totalAge);
        #endregion

        #region Мax(), Min(), Average()
       // var nums = new[] { 1, 7, 45, 23 };

       // int greatest = nums.Max();  // наибольшее - 45
       // int smallest = nums.Min();  // наименьшее - 1
       // double average = nums.Average();  // среднее - 19


       // var students = new List<Student>
       // {
       //    new Student {Name="Андрей", Age=23 },
       //    new Student {Name="Сергей", Age=27 },
       //    new Student {Name="Дмитрий", Age=29 }
       // };

       // // найдем возраст самого старого студента ( 29 )
       // var oldest = students.Max(s => s.Age);

       // // самого молодого ( 23 )
       // var youngest = students.Min(s => s.Age);

       // //  и средний возраст ( 26,3 )
       //average = students.Average(s => s.Age);
        #endregion
    }
    // static List<Student> students;


    class Student
    {
        public string Name;
        public int Age;
    }

    class Contact
    {
        public string Name;
        public long Phone;
    }
  
}