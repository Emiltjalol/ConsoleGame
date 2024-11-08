namespace Konsollspelet2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Draw.DrawGameWorld();
            Character player = Character.CreateCharacter();
            GameLogic game = new GameLogic(player);

            bool isPlaying = true;
            while (isPlaying)
            {
                Console.Clear();

                // Display player status
                Console.WriteLine($"Spelare: {player.Name}");
                Console.WriteLine($"Position: ({player.X}, {player.Y})");
                Console.WriteLine($"Hunger: {player.Hunger}");
                Console.WriteLine();

                // Display movement instructions and controls
                Console.WriteLine("Använd W, A, S, D för att förflytta dig.");
                Console.WriteLine("Tryck på 'E' för att äta mat.");
                Console.WriteLine("Tryck på 'ESC' för att avsluta spelet.");
                Console.WriteLine();

                // Read command
                ConsoleKeyInfo command = Console.ReadKey(true);

                switch (command.Key)
                {
                    case ConsoleKey.W:
                        game.Move("w");
                        break;
                    case ConsoleKey.S:
                        game.Move("s");
                        break;
                    case ConsoleKey.D:
                        game.Move("d");
                        break;
                    case ConsoleKey.A:
                        game.Move("a");
                        break;
                    case ConsoleKey.E:
                        // Create a new Food item and eat it
                        Food apple = new Food("Äpple", 10);  // Create an instance of Food
                        apple.EatFood(player);  // Now call EatFood on the instance
                        Console.WriteLine($"{player.Name} åt ett {apple.FoodName}! Stamina +{apple.Nutrition}.");
                        System.Threading.Thread.Sleep(1000); // Brief pause to show feedback
                        break;
                    case ConsoleKey.Escape:
                        isPlaying = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt kommando.");
                        System.Threading.Thread.Sleep(500);
                        break;
                }
            }
        }
    }
}
;
