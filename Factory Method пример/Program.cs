
using Factory_Method_пример;

class Program
{
    static void Main ()
    {
        #region Описание

        // 1) Создадим абстрактный класс-модель сообщения: abstract class Message
        // 2) Создадим отдельные реализации для e-mail и SMS-сообщений: class SmsMessage и class EmailMessage 
        // 3) Создадим абстрактный класс для рассылок с Фабричным методом: abstract class MessageSender
        // 4) И конкретные реализации под оба вида рассылок: class EmailMessageSender и class SmsMessageSender
        // 5) Теперь используем наши реализации в программу для выполнения рассылки номера заказа клиенту: 
        #endregion

        string messageText = "Ваш номер заказа - 83456";

        // Отправляем заказ по SMS
        MessageSender sender = new SmsMessageSender("+79856455320");
        Message smsMessage = sender.Send(messageText);

        // Отправляем заказ по e-mail
        sender = new EmailMessageSender("orders@myshop.com");
        Message message = sender.Send(messageText);
    }
}