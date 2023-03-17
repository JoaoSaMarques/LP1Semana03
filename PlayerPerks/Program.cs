using System;

namespace PlayerPerks
{
    [ Flags ]
    enum Perks
    {
        NoPerks = 0,
        WaterBreathing = 1,
        Stealth = 2,
        AutoHeal = 4,
        DoubleJump = 8,
    }

    class Program
    {
        static void Main(string[] args)
        {

            string message = Console.ReadLine();
            char[] charArr = message.ToCharArray();  
            //If there is nothing in command
            if (charArr.Length == 0)
            {
                //You have no perks
                Console.WriteLine("You have no perks.");
                return;
            }
            Perks Player = Perks.NoPerks;
            
            //For each char in args
            foreach(char c in charArr)
            {
                switch (c)
                {
                    case 'w':
                        Player ^= Perks.WaterBreathing;
                        break;
                    case 'a':
                        Player ^= Perks.AutoHeal;
                        break;
                    case 's':
                        Player ^= Perks.Stealth;
                        break;
                    case 'd':
                        Player ^= Perks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("I do not recognize this perk");
                        return;
                }
            }

            Console.WriteLine("You have acquired the following perks: ");
            if ((Player & Perks.Stealth) == Perks.Stealth && 
            (Player & Perks.DoubleJump) == Perks.DoubleJump)
            {
                Console.WriteLine("Silent Jumper perk");
            }
            if ((Player & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }

            Console.ReadLine();

        }


    }
}
