using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAIN_OF_RESPOSIBILITY_пример
{
    /// <summary>
    /// Обработчик голосовых уведомлений
    /// </summary>
    class VoiceNotificationHandler : NotificationHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.SmsNotification == true)
                Console.WriteLine("Выполнено уведомление по телефону");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
