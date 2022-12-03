
using Single_responsibility;

class Program
{
    static void Main()
    {
        // принцип единственной обязанности

        IExporter exporter = new PdfExporter();
        Document doc = new Document();
        doc.Text = "Hello World";
        doc.Export(exporter);
    }
}
class Document
{
    public string Text { get; set; }

    public void ScrollUp()
    {
        Console.WriteLine($"Прокрутка вверх");
    }

    public void ScrollDown()
    {
        Console.WriteLine($"Прокрутка вниз");
    }

    public void ZoomIn()
    {
        Console.WriteLine("Увелчиваем масштаб");
    }

    /// <summary>
    ///  Экспорт в любые форматы
    /// </summary>
    public void Export(IExporter exporter)
    {
        exporter.Export(Text);
    }
}