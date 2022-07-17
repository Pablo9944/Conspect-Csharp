using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра
{
    class Axe : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Бьем топором");
        }
    }
}
