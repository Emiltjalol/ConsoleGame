using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsollspelet2
{
    public class Draw
    {
        public static void DrawGameWorld()
        {
            Console.WriteLine("Välkommen till äventyret!");
            Console.WriteLine("[1] Nytt spel");
            Console.WriteLine("[2] Ladda spel");

            ConsoleKeyInfo choice = Console.ReadKey(true);

            switch (choice.Key)
            {
                case ConsoleKey.D1: // Corrected to ConsoleKey.D1
                                    // Code to start a new game
                    Console.WriteLine("Startar nytt spel...");
                    break;
                case ConsoleKey.D2: // Corrected to ConsoleKey.D2
                                    // Code to load a game
                    Console.WriteLine("Laddar spel...");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }
        }
    }
}
