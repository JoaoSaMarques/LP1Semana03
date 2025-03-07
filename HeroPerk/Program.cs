﻿using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string input = args[0];
            Perks playerPerks = Perks.None;
            
            foreach (char c in input)
            {
                switch (c)
                {
                    case 'w': 
                        playerPerks ^= Perks.WarpShift; 
                        break; 
                    case 's': 
                        playerPerks ^= Perks.Stealth; 
                        break;
                    case 'a': 
                        playerPerks ^= Perks.AutoHeal; 
                        break;
                    case 'd': 
                        playerPerks ^= Perks.DoubleJump; 
                        break;
                    default: 
                        Console.WriteLine("!Unknown perk!");
                        return;
                }
            }
            
            if (playerPerks == Perks.None)
            {
                Console.WriteLine("!No perks at all!");
                Console.WriteLine("!Not gonna make it!");
            }
            else
            {
                Console.WriteLine(GetPerksString(playerPerks));

                if ((playerPerks & Perks.Stealth) == Perks.Stealth && 
                    (playerPerks & Perks.DoubleJump) == Perks.DoubleJump)
                {
                    Console.WriteLine("!Silent jumper!");
                }

                if ((playerPerks & Perks.AutoHeal) == 0)
                {
                    Console.WriteLine("!Not gonna make it!");
                }
            }
            
            static string GetPerksString(Perks perks)
            {
                var perkList = new System.Collections.Generic.List<string>();

                if ((perks & Perks.WarpShift) != 0) perkList.Add("WarpShift");
                if ((perks & Perks.Stealth) != 0) perkList.Add("Stealth");
                if ((perks & Perks.AutoHeal) != 0) perkList.Add("AutoHeal");
                if ((perks & Perks.DoubleJump) != 0) perkList.Add("DoubleJump");

                return string.Join(", ", perkList);
            }
        }
    }
}