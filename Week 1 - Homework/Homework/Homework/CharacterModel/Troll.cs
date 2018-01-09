using Homework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.CharacterModel
{
    public class Troll:ICharacter
    {
        public Troll(IWeaponBehavior wb) : base(wb)
        {

        }
    }
}
