
class Program
{
    static void Main()
    {
        Calculator c = new Calculator();
        Func<int, int, int> func = c.FuncPlus();
        int result = func(3, 2);
        Console.WriteLine(result);

        Console.WriteLine();

        Func<int, Func<int, int, int>, int> func2 = (k, f) => f(3,2) * k;
        result = func2(2, func);
        Console.WriteLine(result);
       
        Console.WriteLine();

        Func<int, int> fc = null;
        fc = i =>
        {
            Console.WriteLine(i);
            return i == 0 ? 0 : fc(--i);
        };
        fc(10);

        Console.WriteLine();

        Action action = null;

        for (int cycleCounter = 0; cycleCounter < 4; cycleCounter++)
        {
            action = () => Console.WriteLine(cycleCounter);
            action();
        }
    }
}
class Calculator
{
    public Func<int, int, int> FuncPlus()
    {
        Func<int, int, int> func = (x, y) => x + y;
        return func;
    }
    public Func<int, int, int> FuncMinus()
    {
        Func<int, int, int> func = (x, y) => x - y;
        return func;
    }
   

}
