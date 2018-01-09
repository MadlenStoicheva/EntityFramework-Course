using Homework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.CharacterModel
{
    public class Knight : ICharacter
    {
        public Knight(IWeaponBehavior wb) : base(wb)
        {

        }
    }
}
