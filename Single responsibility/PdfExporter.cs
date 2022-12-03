using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_responsibility
{
    /// <summary>
    /// Экспорт в PDF
    /// </summary>
    class PdfExporter : IExporter
    {
        public void Export(string text)
        {
            Console.WriteLine($"{text}  => Экспортировано в PDF");
        }
    }
}
