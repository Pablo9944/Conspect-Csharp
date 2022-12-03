

class Program
{
    static void Main()
    {
        Singleton singleton = Singleton.Instance;
        singleton.Count = 100;
    }
}

class Singleton
{
   private static Singleton _singleton;
    
    static Singleton ()
    {
        _singleton = new Singleton();
    }

    private Singleton ()
    {

    }

    public static Singleton Instance
    {
        get { return _singleton; }
    
    }
    public int Count { get; set; }

}