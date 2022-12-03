
class Program
{
    static void Main()
    {
      
        MethodAsync('*');
        Method('s');
    
       

    }


    static async Task MethodAsync(char c)
    {
        await Task.Run(() => Method(c));
    }
    static void Method (char c)
    {
        for (int i = 0; i < 100; i++)
        {
            
            Console.Write(c);
            Task.Delay(100).Wait();
          

        }
        
    }
   



}

