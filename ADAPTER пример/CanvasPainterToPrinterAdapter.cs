using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAPTER_пример
{
    class CanvasPainterToPrinterAdapter : IPrinter
    {
        private CanvasPainter _canvasprinter;
        public CanvasPainterToPrinterAdapter(CanvasPainter canvasPainter)
        {
            _canvasprinter = canvasPainter;
        }
        public void Print()
        {
            _canvasprinter.Paint();
        }
    }
}
