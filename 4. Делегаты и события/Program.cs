
class Program
{
    static void Main()
    {
        StringHelper sH = new StringHelper();
        CountDelegate cD1 = sH.GetCount;
        CountDelegate cD2 = sH.GetCountSymbolA;
        
        Console.WriteLine(TestDelegate(cD1,"Test"));
        Console.WriteLine(TestDelegate(cD2, "ABBA"));
    }
    static int TestDelegate (CountDelegate method, string testString)
    {
        return method (testString); 
    }
}

public delegate int CountDelegate(string message);
class StringHelper
{
    public int GetCount (string inputString)
    {
        return inputString.Length;
    }

    public int GetCountSymbolA (string inputString)
    {
        return inputString.Count(c => c == 'A');
    }

    public int GetCountSymbol(string inputString,char symbol)
    {
        return inputString.Count(c => c == symbol);
    }
}