
class Program
{
    //Select() осуществляет выборку объектов в новую сущность. Класс создавать необязательно, выборка возможна в анонимную сущность.
    //Пример: есть база данных пользователей, вы делаете по ним отчёты.
    //Ключевое слово let эффективно сочетать с выборками через Select там, где нужна локальная переменная для выполнения промежуточных операций на ходу.
    //Множественная выборка нужна там, где необходимо соединить данные из нескольких источников.
    //Сочетание методов Skip() и Take() помогает управлять выборкой элементов, если необходимо их отображать постранично
    //SkipWhile() и TakeWhile() нужны для того, чтобы показывать элементы пока верно определенное условие.К примеру,
    //в базе данных у вас есть большой список одинаковых сущностей, и вам нужно достать их все, но после них идут уже сущности с другим свойством, и их вы трогать не хотите.
    //Вам подойдёт метод TakeWhile().

    static void Main()
    {
        // Добавим Россию с её городами
        var russianCities = new List<City>();
        russianCities.Add(new City("Москва", 11900000));
        russianCities.Add(new City("Санкт-Петербург", 4991000));
        russianCities.Add(new City("Волгоград", 1099000));
        russianCities.Add(new City("Казань", 1169000));
        russianCities.Add(new City("Севастополь", 449138));

        var result = from c in russianCities
                     where c.Population > 1000000
                     orderby c.Population descending
                     select c;

        foreach (var item in result)
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine();

       var result2 = russianCities.Where(c => c.Name.Length < 10).OrderBy(c => c.Name.Length);
        foreach (var item in result2)
        {
            Console.WriteLine(item.Name);
        }
             

    }
}
// Создадим модель класс для города
public class City
{
    public City(string name, long population)
    {
        Name = name;
        Population = population;
    }

    public string Name { get; set; }
    public long Population { get; set; }
}