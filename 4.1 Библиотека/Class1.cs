namespace _4._1_Библиотека
{
    public class MyClass
    {
        public void MyMethod (bool flag, string input, int count)
        {
            if (!flag)
                return;

            for (int i = 0; i < count; i++)
                Console.WriteLine(input);

            Console.ReadLine();
           
        }
    }
}