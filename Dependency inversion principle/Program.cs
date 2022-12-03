
class Program
{
    static void Main()
    {
        // Dependency inversion principle

        // В соответствии с этим принципом рекомендуется программировать на уровне интерфейсов, а не их конкретных реализаций.\
        // Абстракция (интерфейс — самый распространенный пример) не должна зависеть от деталей реализации. Наоборот, реализация должна зависеть от абстракции.

        //Система должна быть организована от общего к частному, соответственно, верхние модули не должны зависеть от нижних.
        //Наверху находится самый высокий уровень абстракции (по сути, этот подход применяется в проектировании любых систем, не только в программировании, но и в жизни).


        //  выводим на монитор
        var connectedMonitor = new VideoAdapter(new Monitor());
        connectedMonitor.Display();

        //  выводим на телевизор
        var connectedTv = new VideoAdapter(new Tv());
        connectedTv.Display();
    }
}
/// <summary>
/// Адаптер для вывода изображений
/// </summary>
class VideoAdapter
{
    public string Text { get; set; }
    public IHdmiInterface HdmiInterface { get; set; }

    public VideoAdapter(IHdmiInterface hdmiInterface)
    {
        HdmiInterface = hdmiInterface;
    }

    /// <summary>
    /// Метод вывода
    /// </summary>
    public void Display()
    {
        HdmiInterface.Display(Text);
    }
}

/// <summary>
/// Универсальный интерфейс для вывода изображения
/// </summary>
public interface IHdmiInterface
{
    void Display(string text);
}
class Monitor : IHdmiInterface
{
    public void Display(string text)
    {
        Console.WriteLine("Вывод на монитор");
    }
}
class Tv : IHdmiInterface
{
    public void Display(string text)
    {
        Console.WriteLine("Вывод на телевизор");
    }
}