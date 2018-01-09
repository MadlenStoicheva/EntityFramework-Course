using Homework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.WeaponBehavior
{
    public class MutatedSeaWeaponBehavior: IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("MutatedSeaWeapon !");
        }
    }
}
