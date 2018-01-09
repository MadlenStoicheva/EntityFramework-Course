using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Interface
{
    public abstract class ICharacter
    {
        private IWeaponBehavior weaponBehavior;

        public ICharacter(IWeaponBehavior qb)
        {
            this.weaponBehavior = qb;
        }

        public void PerformWeapon()
        {
            this.weaponBehavior.UseWeapon();
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting!");
        }
    }
}
