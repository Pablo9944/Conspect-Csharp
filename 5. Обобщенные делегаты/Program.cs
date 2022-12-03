
class Program
{
    static void Main()
    {
        Student student = new Student();
        Action<string> action = Show;
        student.Moving += student_Moving;
        student.Move(3);
    }
    static void Show (string message)
    {
        Console.WriteLine(message);
    }
    static void student_Moving(object sender, MovingEvenArgs e)
    {
        Console.WriteLine(e.message);
    }
}

public delegate void ShowMessage(string mesage);
class Student
{
    public void Move (int distance)
    {
        for (int i = 0; i < distance; i++)
        {
            Thread.Sleep(1000);
            Moving(this, new MovingEvenArgs(string.Format("Пройдено киллометров {0}", i)));
        }
    }

    public event EventHandler<MovingEvenArgs> Moving;
}
class MovingEvenArgs : EventArgs
{
    public string message { get; set; }
    public MovingEvenArgs(string message)
    {
        this.message = message;
    }
}