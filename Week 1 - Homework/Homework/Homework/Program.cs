using Homework.CharacterModel;
using Homework.Interface;
using Homework.WeaponBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            ICharacter[] characters = new ICharacter[]
           {
                new King(new AxeBehavior()),
                new Knight(new BowAndArrowBehavior()),
                new Queen(new Knife()),
                new Smurfette(new MutatedSeaWeaponBehavior()),
                new SmurfStorm(new SwordBehavior()),
                new Troll(new PaperClipBehavior())
           };


            foreach (var character in characters)
            {
                Console.WriteLine("Character of type {0}", character.GetType().Name);
                character.PerformWeapon();
                character.Fight();
                Console.WriteLine("========================");
            }
        }
    }
}
