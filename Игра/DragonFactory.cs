using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра
{
    class DragonFactory : IMonsterFactory
    {
        public IMovement CreateMovement()
        {
            return new FlyMovement();
        }

        public IWeapon CreateWeapon()
        {
            return new FireBreath();
        }
    }
}
