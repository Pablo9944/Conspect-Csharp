
class Program
{
    static void Main()
    {
        MyClass mc = new MyClass();
        string test = mc.Word();
        Console.WriteLine(test);
    }
}
class MyClass
{
    public string Word() => "WORD";
}