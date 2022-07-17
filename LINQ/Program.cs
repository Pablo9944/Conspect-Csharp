using System.Collections;
class Program
{
    static void Main()
    {
        TestSet set = new TestSet();
        var filtredSet = set.Where(s => s > 50);
        
        foreach (var item in filtredSet)
                 Console.WriteLine(item);
        
        Console.WriteLine();

       var filtredSet1 = set.Select(s => "*" + s.ToString() + "*");
        foreach (var item in filtredSet1)
            Console.WriteLine(item);
        
        Console.WriteLine();

        var result = set.Aggregate(0, (acc, i) => acc + i);
        Console.WriteLine(result);

        Console.WriteLine();

        var result1 = set.Select(s => new { number = s, isEven = s % 2 == 0 }).OrderBy(s => s.isEven);
        foreach (var item in result1)
        {
            Console.WriteLine(item);
        }
    }  
}
class TestSet:IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i <= 100; i++)
        {
            yield return i;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

}