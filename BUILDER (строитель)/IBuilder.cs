using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUILDER__строитель_
{
    /// <summary>
    /// Абстрактный интерфейс строителя
    /// </summary>
    interface IBuilder
    {
        void FirstStage();
        void SecondStage();
        void ThirdStage();
        Product GetBuildingResult();
    }
}
