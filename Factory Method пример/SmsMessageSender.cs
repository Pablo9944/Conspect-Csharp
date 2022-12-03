using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_пример
{
    /// <summary>
    /// Класс для рассылки SMS
    /// </summary>
    class SmsMessageSender : MessageSender
    {
        public SmsMessageSender(string @from) : base(@from)
        { }
        public override Message Send(string text)
        {
            return new SmsMessage();
        }
    }
}
