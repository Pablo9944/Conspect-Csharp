using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_пример
{
    abstract class MessageSender
    {
        public string From { get; set; }
        public MessageSender(string @from)
        {
            From = @from;
        }

        // Фабричный метод
        abstract public Message Send(string text);
    }
}
