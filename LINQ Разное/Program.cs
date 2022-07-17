
class Program
{
    static void Main()
    {
        var listTest1 = new List<string>
        {
            "Один",
            "Два",
            "Три",
            "Четыре",
            "Пять",
        };
       
        int i = 1;
        var list1 = listTest1.Select(l => $"{i++} {l}");
        
        foreach (var item in list1)
            Console.WriteLine(item);
        Console.WriteLine();

        var listTest2 = new List<string>
        {
            "Один1",
            "Два",
            "Три1",
            "Четыре",
            "Пять1",
        };

        var list2 = listTest2.OrderBy(x => x.Contains("1")).ThenBy(x=>x);

        foreach (var item in list2)
            Console.WriteLine(item);
        Console.WriteLine();


        var listTest3 = new List<string>
        {
            "Один",
            "Два",
            "Три",
            "Четыре",
            "Пять",
            "Два",
        };

        var list3 = listTest3.GroupBy(g => g).Where(g => g.Count() > 1).Select(g => g.Key);
        foreach (var item in list3)
            Console.WriteLine(item);
        Console.WriteLine();


        var listTest4 = new List<string>
        {
            "Один",
            "Два",
            "Три",
            "Четыре",
            "Пять",
            "Два",
        };

        var list4 = listTest4.Intersect(listTest3);
        foreach (var item in list4)
            Console.WriteLine(item);
    }
}