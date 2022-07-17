class Program
{
    static void Main(string[] args)
    {
        #region Commands
        // push - добавляет
        // pop - просмотр и удаление
        // peek - просмотр 
        #endregion

        //LIFO
        //  создадим числовой стек
        Stack<int> numbers = new Stack<int>();

        numbers.Push(3); // в стеке 3
        numbers.Push(5); // в стеке 5, 3
        numbers.Push(8); // в стеке 8, 5, 3

        Console.WriteLine("Элементы числового стека: ");
        foreach (var number in numbers)
            Console.WriteLine(number);

        Console.WriteLine($"Извлекаем верхний элемент из стека: {numbers.Pop()}");
        //  в стеке остались числа 5 и 3

        Console.WriteLine();

        // создадим стек объектов
        Stack<Person> persons = new Stack<Person>();
        persons.Push(new Person() { Name = "Иван" });
        persons.Push(new Person() { Name = "Сергей" });
        persons.Push(new Person() { Name = "Анна" });

        Console.WriteLine("Элементы стека объектов: ");
        foreach (Person p in persons)
            Console.WriteLine(p.Name);

        Console.WriteLine($"Извлекаем верхний элемент из стека объектов: {persons.Pop().Name}");
    }
}
class Person
{
    public string Name { get; set; }
}
