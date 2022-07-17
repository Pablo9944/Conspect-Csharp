
class Program
{
    static void Main()
    {
        var listTest1 = new List<string>
        {
            "Один",
            "Два",
            "Три"
        };


        // For
        Enumerable.Range(0, 3).AsParallel().ForAll(x =>
        {
            Console.WriteLine(listTest1[x]);
        });
        Console.WriteLine();

        // foreach
        listTest1.AsParallel().ForAll(x =>
        {
            Console.WriteLine(x);
        });

        
    }
}