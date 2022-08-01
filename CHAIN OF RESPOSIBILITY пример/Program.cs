
using CHAIN_OF_RESPOSIBILITY_пример;

class Program
{
    static void Main()
    {
        #region Описание
        // Мы — банковский сервис, и должны уведомить человека об операции на его счету любым доступным способом.
        // У человека (клиента) может быть предусмотрено несколько способов уведомления (SMS, звонок, электронная почта), но нам неважно, какой из них использовать. 

        // 1) Создадим базовый класс обработчика: abstract class NotificationHandler
        // 2) И отдельные обработчики для каждого из видов уведомлений: class EmailNotificationHandler и class SmsNotificationHandler и class VoiceNotificationHandler
        // 3) Теперь создадим класс-получатель: class Receiver
        // 4) И применим в итоговой реализации: 
        #endregion

        Receiver receiver = new Receiver(false, true, true);

        NotificationHandler emailNotificationHandler = new EmailNotificationHandler();
        NotificationHandler voiceNotificationHandler = new VoiceNotificationHandler();
        NotificationHandler smsNotificationHandler = new SmsNotificationHandler();

        emailNotificationHandler.Successor = smsNotificationHandler;
        smsNotificationHandler.Successor = voiceNotificationHandler;

        emailNotificationHandler.Handle(receiver);
    }
}