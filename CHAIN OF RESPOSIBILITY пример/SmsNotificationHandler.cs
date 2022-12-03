using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAIN_OF_RESPOSIBILITY_пример
{
    /// <summary>
    /// Обработчик SMS-уведомлений
    /// </summary>
    class SmsNotificationHandler : NotificationHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.VoiceNotification == true)
                Console.WriteLine("Выполнено уведомление по SMS");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
