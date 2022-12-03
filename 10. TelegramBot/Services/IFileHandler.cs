﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10.TelegramBot.Services
{
    public interface IFileHandler
    {
        Task Download(string fileId, CancellationToken ct);
        string Process(string param);
    }
}
