using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра
{
    interface IMonsterFactory
    {
        IMovement CreateMovement();
        IWeapon CreateWeapon();
    }
}
