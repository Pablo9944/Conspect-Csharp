
class Program
{
    static void Main ()
    {
        string text = "огого";
        int result = text.GetSymbolCount('о');
        Console.WriteLine(result);

    }

}
public static class StringHelper
{
    public static int GetSymbolCount (this string text, char symbol)
    {
        int count = 0;
        char[] arr = text.ToCharArray();

        foreach (var item in arr)
        {
            if(item == symbol)
            {
                count++;
            }
        }
        return count;
    }
}