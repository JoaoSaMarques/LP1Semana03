﻿using System;

namespace HeroPerks
{
    [Flags]
    internal enum HeroPerks
    {
        WaterBreathing = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    }

    internal static class Program
    {
        private static void Main(string[] args)
        {
            HeroPerks playerPerks = 0;
            
            Console.WriteLine("Please input your desired perks:");
            string userInput = Console.ReadLine();

            if (userInput != null && userInput.Length == 0 || userInput == null)
            {
                Console.WriteLine("No perks at all!");
                return;
            }
            
            foreach (char t in userInput)
            {
                if (t != 'w' && t != 'a' && t != 's' && t != 'd')
                {
                    Console.WriteLine("Unknown perk!");
                    return;
                }
            
                switch (t)
                {
                    case 'w':
                        playerPerks |= HeroPerks.WaterBreathing;
                        break;
                    case 'a':
                        playerPerks |= HeroPerks.Stealth;
                        break;
                    case 's':
                        playerPerks |= HeroPerks.AutoHeal;
                        break;
                    case 'd':
                        playerPerks |= HeroPerks.DoubleJump;
                        break;
                    default:
                        return;
                }
            }
            
            Console.WriteLine($"Player perks: {playerPerks}");
            
            if ((playerPerks & (HeroPerks.Stealth | HeroPerks.DoubleJump)) == (HeroPerks.Stealth | HeroPerks.DoubleJump))
            {
                Console.WriteLine("Silent jumper!");
            }

            if ((playerPerks & HeroPerks.AutoHeal) == HeroPerks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}