using ArenaGame;
using System;

namespace ConsoleGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter number of rounds: ");
            if (!int.TryParse(Console.ReadLine(), out int rounds) || rounds <= 0)
            {
                Console.WriteLine("Invalid number of rounds. Please enter a positive integer.");
                return;
            }

            // Initialize win counts for each type of hero
            int knightWins = 0;
            int fairyWins = 0;
            int nymphWins = 0;
            int rogueWins = 0;

            // Create weapons for demonstration
            Sword sword = new Sword("Excalibur", 100, "Fast", 80, "Holy Slash");
            Shuriken shuriken = new Shuriken("Shadow Star", 50, "Very Fast", 90, "Piercing Throw");
            Poison poison = new Poison("Viper Venom", 30, "Slow", 70, "Lethal Toxin", 20);

            // Loop through each round of battles
            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine($"Round {i + 1}");

                // Create heroes for this round
                Hero knight = new Knight("Sir Lancelot");
                Hero fairy = new Fairy("Tinkerbell");
                Hero nymph = new Nymph("Aphrodite");
                Hero rogue = new Rogue("Robin Hood");

                // First battle: Knight vs. Fairy
                Hero winner1 = new Arena(knight, fairy).Battle();
                Console.WriteLine($"Winner of Knight vs. Fairy: {winner1.Name}");

                // Use the sword if the knight wins
                if (winner1 is Knight)
                {
                    sword.Slash(fairy);
                }

                // Second battle: Nymph vs. Rogue
                Hero winner2 = new Arena(nymph, rogue).Battle();
                Console.WriteLine($"Winner of Nymph vs. Rogue: {winner2.Name}");

                // Use the shuriken if the rogue wins
                if (winner2 is Rogue)
                {
                    shuriken.Throw(nymph);
                }

                // Apply poison to the final winner
                poison.ApplyPoison(winner2);

                // Final battle: Winner1 vs. Winner2
                Hero finalWinner = new Arena(winner1, winner2).Battle();
                Console.WriteLine($"Winner of final battle: {finalWinner.Name}");

                // Update win counts
                if (finalWinner is Knight)
                {
                    knightWins++;
                }
                else if (finalWinner is Fairy)
                {
                    fairyWins++;
                }
                else if (finalWinner is Nymph)
                {
                    nymphWins++;
                }
                else if (finalWinner is Rogue)
                {
                    rogueWins++;
                }
            }

            // Print results
            Console.WriteLine();
            Console.WriteLine($"Knight has won {knightWins} battles.");
            Console.WriteLine($"Fairy has won {fairyWins} battles.");
            Console.WriteLine($"Nymph has won {nymphWins} battles.");
            Console.WriteLine($"Rogue has won {rogueWins} battles.");

            Console.ReadLine();
        }
    }
}
