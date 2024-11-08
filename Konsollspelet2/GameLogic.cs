using Konsollspelet2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsollspelet2
{
    public class GameLogic
    {
        private Character _character;

        public GameLogic(Character character)
        {
            _character = character;
        }

        public void Move(string direction)
        {
            switch (direction.ToLower())
            {
                case "w":
                    _character.Y++;
                    break;
                case "s":
                    _character.Y--;
                    break;
                case "d":
                    _character.X++;
                    break;
                case "a":
                    _character.X--;
                    break;
                default:
                    Console.Write("Ogiltig riktning!");
                    return;
            }

            _character.Hunger -= 1; // Minskar hunger vid varje rörelse
        }
        public static Character CreateCharacter()
        {
            Console.WriteLine("Välkommen till äventyret! Vänligen ange ditt karaktärsnamn:");
            string name = Console.ReadLine();
            return new Character(name);
        }
    }
}
