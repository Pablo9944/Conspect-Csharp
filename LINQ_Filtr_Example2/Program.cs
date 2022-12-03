
class Program
{
    static void Main()
    {
        // Словарь для хранения стран с городами
        var Countries = new Dictionary<string, List<City>>();

        // Добавим Россию с её городами
        var russianCities = new List<City>();
        russianCities.Add(new City("Москва", 11900000));
        russianCities.Add(new City("Санкт-Петербург", 4991000));
        russianCities.Add(new City("Волгоград", 1099000));
        russianCities.Add(new City("Казань", 1169000));
        russianCities.Add(new City("Севастополь", 449138));
        Countries.Add("Россия", russianCities);

        // Добавим Беларусь
        var belarusCities = new List<City>();
        belarusCities.Add(new City("Минск", 1200000));
        belarusCities.Add(new City("Витебск", 362466));
        belarusCities.Add(new City("Гродно", 368710));
        Countries.Add("Беларусь", belarusCities);

        // Добавим США
        var americanCities = new List<City>();
        americanCities.Add(new City("Нью-Йорк", 8399000));
        americanCities.Add(new City("Вашингтон", 705749));
        americanCities.Add(new City("Альбукерке", 560218));
        Countries.Add("США", americanCities);

        var cities = from country in Countries // пройдемся по странам
                     from city in country.Value // пройдемся по городам
                     where city.Population > 1000000 // выберем города - миллионники
                     orderby city.Population descending // отсортируем по населению
                     select city;

        foreach (var city in cities)
            Console.WriteLine(city.Name + " - " + city.Population);


        string[] text = { "Раз два три",
                           "четыре пять шесть",
                           "семь восемь девять" };

        var resultSumWord = from t in text
                            from word in t.Split(' ')
                            select word;
        foreach (var item in resultSumWord)
        {
            Console.WriteLine(item);
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

    public string Name
    {
        get;
        set;
    }
    public long Population
    {
        get;
        set;
    }
}