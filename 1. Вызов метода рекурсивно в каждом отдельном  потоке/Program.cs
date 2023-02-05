

class Program
{
    static int deep;
    static void Main()
    {
        //Напишите программу, в которой метод будет вызываться рекурсивною.
        //Каждый новый вызов метода выполняется в отдельном потоке.
        Thread thread = new Thread(Recusrsion) { Name = "Thread " + deep };
        thread.Start();
         
        



    }

    static void Recusrsion ()
    {
        Console.WriteLine($"say Thread {Thread.CurrentThread.Name}");
        Thread.Sleep(1000);  
        Thread thread = new Thread(Recusrsion);
        deep++;
        thread.Name = "Thread " + deep;
        thread.Start();
    }
}

