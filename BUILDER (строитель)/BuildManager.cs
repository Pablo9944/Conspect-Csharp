using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUILDER__строитель_
{
    /// <summary>
    /// Объект, инкапсулирующий процесс строительства
    /// </summary>
    class BuildManager
    {
        IBuilder Builder;
        public BuildManager(IBuilder builder)
        {
            Builder = builder;
        }
        public void StartBuildingProcess()
        {
            Builder.FirstStage();
            Builder.SecondStage();
            Builder.ThirdStage();
        }
    }
}
