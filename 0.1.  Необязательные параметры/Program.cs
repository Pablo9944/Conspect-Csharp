


class Program
{
    static void Main()
    {
        int result = Sum(5, 7,false);
        Console.WriteLine();

        int firstValue = 1;
        int secondValue = 2;

        result = Sum(b: firstValue, a: secondValue, enableLogging:true);


        // Именнованные параметры
        int check = Sum(b:4,a:2);
        Console.WriteLine(check);

    }
                               
    
    
                               // может быть любой тип данных ( int c = 55)
    static int Sum (int a, int b, bool enableLogging = false )
    {
        int result = a + b ;

        string message = "значение переменной {0}";
        
        if (enableLogging)
        {
            Console.WriteLine(message,a);
            Console.WriteLine(message,b);
            Console.WriteLine($"Cумма {result = a + b}");  
        }
        return result;

    }
}