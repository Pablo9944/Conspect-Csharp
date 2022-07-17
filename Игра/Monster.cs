using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра
{
     class Monster
    {
        private IWeapon _weapon;
        private IMovement _movement;

        /// <summary>
        ///  Метод - конструктор, где создаются объекты при помощи фабрики
        /// </summary>
        public Monster(IMonsterFactory factory)
        {
            _weapon = factory.CreateWeapon();
            _movement = factory.CreateMovement();
        }

        public void Move()
        {
            _movement.Start();
        }
        public void Hit()
        {
            _weapon.Attack();
        }
    }
}
