
class Program
{
    // Parallel - много жрёт ресурсов
    static void Main()
    {
        var listTest1 = new List<string>
        {
            "Один",
            "Два",
            "Три" 
        };
        Parallel.Invoke(
            () =>
            {
                Console.WriteLine(listTest1[0]);
            },
            () =>
            {
                Console.WriteLine(listTest1[1]);
            },
            () =>
            {
                Console.WriteLine(listTest1[2]);
            });

        Console.WriteLine();

        Parallel.For(0, 3, x =>
        {
            Console.WriteLine(listTest1[x]);
        });
        Console.WriteLine();

        Parallel.ForEach(listTest1,x=>
        {
            Console.WriteLine(x);
        });

        //Удаляет ПАРАЛЛЕЛЬНО ФАЙЛЫ
        var listTest2 = new List<string>
        {
            @"F:\1.txt",
            @"F:\2.txt",
            @"F:\3.txt"
        };

        Parallel.ForEach(listTest2, x => File.Delete(x));
    }
}