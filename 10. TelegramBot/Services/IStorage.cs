using _10.TelegramBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.TelegramBot.Services
{
    public  interface IStorage
    {
        /// <summary>
        /// Получение сессии пользователя по идентификатору
        /// </summary>
        Session GetSession(long chatId);
    }
}
