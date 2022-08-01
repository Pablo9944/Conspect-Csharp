using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_пример
{
    /// <summary>
    /// Сам объект, поведение которого должно изменяться
    /// </summary>
    class ContextObject
    {
        public State State { get; set; }
        public ContextObject(State state)
        {
            State = state;
        }

        public void Switch()
        {
            State.Handle(this);
        }
    }
}
