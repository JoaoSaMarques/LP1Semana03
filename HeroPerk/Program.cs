using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Write("Please provide a single argument: ");
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
                        playerPerks ^= Perks.WarpShift; // Toggle perk
                        break;
                    case 'a':
                        playerPerks ^= Perks.Stealth; // Toggle perk
                        break;
                    case 's':
                        playerPerks ^= Perks.AutoHeal; // Toggle perk
                        break;
                    case 'd':
                        playerPerks ^= Perks.DoubleJump; // Toggle perk
                        break;
                    default:
                        hasInvalidChar = true;
                        break;
                }
            }





        }
    }
}
