
using ADAPTER_пример;

class Program
{
    static void Main()
    {
        #region Описание
        // У вас есть программа, которая отправляет на печать изображения сторонним устройствам.
        // Для печати изображений у вас есть класс ImageDrawer.
        // В нём вы работаете с принтером, у него есть понятный интерфейс, который вы себе подключили. 
        // В какой-то момент вам становится необходимо добавить поддержку печати на холсте
        // , но в классе ImageDrawer использование печати на холсте не предусмотрено
        //  , поэтому нужно либо переписать его, либо можно использовать адаптер, как показано ниже:

        // 1) Создадим интерфейсы устройств: interface IPrinter и  interface IPainter
        // 2) Реализуем интерфейсы в классах для работы с устройствами: class PaperPrinter и class CanvasPainter
        // 3) Наш класс, с помощью которого мы печатаем (который поддерживает печать на бумаге, но не поддерживает печать на холсте): class ImageDrawer
        #endregion

        // Нам надо отрисовать изображение на бумаге и холсте
        // Запускаем класс для отрисовки
        var imageDrawer = new ImageDrawer();

        // Создаем класс для работы с бумажным принтером
        PaperPrinter paperPrinter = new PaperPrinter();
        // Запускаем отрисовку на бумаге
        imageDrawer.DrawWith(paperPrinter);

        // Теперь нужна печать на холсте
        CanvasPainter canvasPainter = new CanvasPainter();

        // используем адаптер
        IPrinter imagePrinter = new CanvasPainterToPrinterAdapter(canvasPainter);
        // Запускаем печать на холсте
        imageDrawer.DrawWith(imagePrinter);
        Console.Read();
    }
}