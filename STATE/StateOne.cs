using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_пример
{
    /// <summary>
    /// Первое состояние
    /// </summary>
    class StateOne : State
    {
        public override void Handle(ContextObject contextObject)
        {
            contextObject.State = new StateTwo();
        }
    }
}
