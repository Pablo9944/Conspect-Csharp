
class Program
{
    static void Main ()
    {
        List<int> lst = new List<int>();

        var a = new { Name = "Pablo", age = 35 };

        // массив анонимных типов
        var arr  = new[] { a };
        var result = arr.ToList();
       
    }
}