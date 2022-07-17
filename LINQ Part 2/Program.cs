
class Program
{
    static void Main()
    {
        #region Методы
        //Except() -  возвращает только уникальные элементы.
        //Intersect() - Для нахождения общих элементов коллекций
        //Union() - Соединить две коллекции в одну без повторений
        //Concat() - прибавить элементы одной коллекции к другой, не заботясь о дублировании
        //Distinct() - проверить коллекцию на наличие дубликатов и удалить их 
        #endregion

        #region Except()
        //string[] drinks = { "Вода", "Кока-кола", "Лимонад", "Вино" };
        //// Алкогольные напитки
        //string[] alcohol = { "Вино", "Пиво", "Сидр" };

        //// Убираем алкоголь из ассортимента
        //var drinksForKids = drinks.Except(alcohol);

        //foreach (string drink in drinksForKids)
        //    Console.WriteLine(drink);
        //Console.WriteLine();
        #endregion


        #region Intersect()
        //string[] cars = { "Волга", "Москвич", "Нива", "Газель" };
        //string[] buses = { "Газель", "Икарус", "ЛиАЗ" };

        //var microBuses = cars.Intersect(buses);

        //foreach (string mb in microBuses)
        //    Console.WriteLine(mb);
        //Console.WriteLine();
        #endregion


        #region Union()
        //string[] cars = { "Волга", "Москвич", "Москвич", "Нива", "Газель" };
        //string[] buses = { "Газель", "Икарус", "ЛиАЗ" };

        //var vehicles = cars.Union(buses);

        //foreach (string v in vehicles)
        //    Console.WriteLine(v);
        #endregion

        #region Concat()
        //string[] cars = { "Волга", "Москвич", "Нива", "Газель" };
        //string[] buses = { "Газель", "Икарус","Москвич", "ЛиАЗ" };

        //var microBuses = cars.Concat(buses);

        //foreach (string mb in microBuses)
        //    Console.WriteLine(mb);
        //Console.WriteLine();
        #endregion

        #region Distinct()
        //string[] cars = { "Волга", "Москвич", "Москвич", "Нива", "Газель" };

        //// удалим дубликаты
        //var uniqueCars = cars.Distinct();

        //foreach (string v in uniqueCars)
        //    Console.WriteLine(v);
        #endregion


        // читаем ввод
        var text = Console.ReadLine();

        // сохраняем список знаков препинания и символ пробела в коллекцию
        var punctuation = new List<char>() { ' ', ',', '.', ';', ':', '!', '?' };

        // валидация ввода
        if (string.IsNullOrEmpty(text))
        {
            Console.WriteLine("Вы ввели пустой текст");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Текст без знаков препинания: ");

        // так как строка - это массив char, мы можем вызвать метод  except  и удалить знаки препинания
        var noPunctuation = text.Except(punctuation).ToArray();

        // вывод
        Console.WriteLine(noPunctuation);
    }
}