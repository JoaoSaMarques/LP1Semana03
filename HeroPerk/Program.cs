using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Please provide a single argument.");
                return;
            }

            string input = args[0];
            Perks playerPerks = 0;
            bool hasInvalidChar = false;

            foreach (char c in input)
            {
                switch (c)
                {
                    case 'w':
                        playerPerks ^= Perks.WarpShift;
                        break;
                    case 'a':
                        playerPerks ^= Perks.Stealth;
                        break;
                    case 's':
                        playerPerks ^= Perks.AutoHeal;
                        break;
                    case 'd':
                        playerPerks ^= Perks.DoubleJump;
                        break;
                    default:
                        hasInvalidChar = true;
                        break;
                }
            }

            if (hasInvalidChar)
            {
                Console.WriteLine("!Unknown perk!");
                return;
            }

            if (playerPerks == 0)
            {
                Console.WriteLine("!No perks at all!");
                Console.WriteLine("!Not gonna make it!");
                return;
            }

            // Print the perks
            Console.WriteLine(playerPerks);

            // Check for specific perks
            if ((playerPerks & Perks.Stealth) != 0 && (playerPerks & Perks.DoubleJump) != 0)
            {
                Console.WriteLine("!Silent jumper!");
            }

            if ((playerPerks & Perks.AutoHeal) == 0)
            {
                Console.WriteLine("!Not gonna make it!");
            }
        }
    }
}