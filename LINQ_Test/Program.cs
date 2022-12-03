
class Program
{
    static void Main ()
    {
        /*from variable in collection // каждую переменную в коллекции
         where condition // для которой выполняется условие
         select variable; // добавить в выборку*/


        //string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

        //var selectedPeople = from p in people // промежуточная переменная p 
        //                     where p.StartsWith("А") // фильтрация по условию
        //                     orderby p // сортировка по возрастанию (дефолтная)
        //                     select p; // выбираем объект и сохраняем в выборку

        //foreach (string s in selectedPeople)
        //    Console.WriteLine(s);

        //string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

        //var selectedPeople = (from p in people
        //                      where p.ToUpper().StartsWith("А")
        //                      orderby p
        //                      select p).Count();

        //Console.WriteLine($"В выборке {selectedPeople} чел");

        // LINQ - Вырежане
        string[] Name = { "A", "B", "C", "A" };

        var result = from p in Name
                     where p.StartsWith("A")
                     select p;

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // Методы расширения
        var result2 = Name.Where(p => p.StartsWith("A"))
                           .OrderBy(p => p);
        foreach (var item in result2)
        {
            Console.WriteLine(item);
        }

        var objects = new List<object>()
        {
           1,
           "Сергей ",
           "Андрей ",
           300,
        };

        Console.WriteLine();

        var result3 = from p in objects
                      where p is string
                      orderby p
                      select p;
        foreach (var item in result3)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        var result4 = objects.Where(p => p is string).OrderBy(p => p);

        foreach (var item in result4)
        {
            Console.WriteLine(item);
        }


    }
}