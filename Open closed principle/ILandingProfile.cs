using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_closed_principle
{
    /// <summary>
    /// Общий интерфейс для профилей посадки
    /// </summary>
    public interface ILandingProfile
    {
       void Execute();
    }
}
