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
        }
    }
}
