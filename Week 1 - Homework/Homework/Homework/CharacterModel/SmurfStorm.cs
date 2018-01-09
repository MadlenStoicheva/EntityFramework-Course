using Homework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.CharacterModel
{
    public class SmurfStorm:ICharacter
    {
        public SmurfStorm(IWeaponBehavior wb) : base(wb)
        {

        }
    }
}
