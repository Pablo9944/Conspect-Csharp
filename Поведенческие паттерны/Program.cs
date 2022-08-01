
class Program
{
    static void Main()
    {
        // CHAIN OF RESPOSIBILITY -  ЦЕПОЧКА ОБЯЗАННОСТЕЙ (позволяет избежать жесткой привязки отправителя запроса к получателю.)

        // STATE - СОСТОЯНИЕ  (Наши объекты получают возможность менять своё поведение в зависимости от внутреннего состояния.)

        // OBSERVER - НАБЛЮДАТЕЛЬ ( Множество объектов могут быть потребителями информации из одного источника (наблюдателями). При изменении наблюдаемого объекта автоматически происходит оповещение всех наблюдателей. )


        #region CHAIN OF RESPOSIBILITY
        // Признаки того, что мы можем использовать цепочку: 
        // Имеется более одного объекта, который способен обрабатывать запрос.
        // Нам нужно, чтобы запрос был обработан одни или несколькими объектами, но точно не определено, кем именно.
        // Если у нас динамически задаётся набор объектов.
        #endregion
       
        // Первый обработчик
        Handler handlerOne = new HandlerOne();

        // Второй обработчик
        Handler handlerTwo = new HandlerTwo();

        // Передача запроса по цепочке и обработка
        handlerOne.Successor = handlerTwo;
        handlerOne.HandleRequest(2);

    }
}


/// <summary>
/// Базовый интерфейс обработчика
/// </summary>
abstract class Handler
{
    public Handler Successor { get; set; }
    public abstract void HandleRequest(int condition);
}
/// <summary>
/// Реализация первого обработчика
/// </summary>
class HandlerOne : Handler
{
    public override void HandleRequest(int condition)
    {
        if (condition == 1)
        {
            // Завершение обработки при выполненном условии
        }
        else if (Successor != null)
        {
            // Условие не выполнено - передаем дальше по цепи
            Successor.HandleRequest(condition);
        }
    }
}
/// <summary>
/// Реализация второго обработчика
/// </summary>
class HandlerTwo : Handler
{
    public override void HandleRequest(int condition)
    {
        if (condition == 2)
        {
            // Завершение обработки при выполненном условии
        }
        else if (Successor != null)
        {
            // Условие не выполнено - передаем дальше по цепи
            Successor.HandleRequest(condition);
        }
    }
}
/*Здесь использование цепочки обязанностей дает нам такие преимущества: 
Связи между объектами будут ослаблены. Отправитель и получатель запросов не знают друг о друге ничего. Клиенту же неизвестна цепочка объектов, какие объекты её составляют и как запрос в ней передаётся.
Можно легко добавлять новые объекты, реализующие общий интерфейс.*/
