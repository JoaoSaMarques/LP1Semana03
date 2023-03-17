using System;

namespace PlayerPerks
{
    [ Flags ]
    enum Perks
    {
        NoPerks = 0,
        Fly = 1,
        XrayVision = 2,
        SuperStrength = 4,
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write amount of players");
            int TotalPlayers = Convert.ToInt32(Console.ReadLine());
            
            for (int n = 0; n < TotalPlayers; n++) 
            {
                //string
                string message = Console.ReadLine();
                //Convert string to char array
                char[] charArr = message.ToCharArray();  
                //If there is nothing in array
                if (charArr.Length == 0)
                {
                    //You have no perks
                    Console.WriteLine("You have no perks.");
                    return;
                }
                Perks Player = Perks.NoPerks;
                
                //For each char in CharArr
                foreach(char c in charArr)
                {
                    switch (c)
                    {
                        case 'f':
                            Player ^= Perks.Fly;
                            break;
                        case 'x':
                            Player ^= Perks.XrayVision;
                            break;
                        case 's':
                            Player ^= Perks.SuperStrength;
                            break;
                        default:
                            Console.WriteLine("I do not recognize this perk");
                            return;
                    }
                }
                Console.WriteLine(Player);
                //If you have Fly and SuperStrength
                Console.WriteLine("You have acquired the following perks: ");
                if ((Player & Perks.Fly) == Perks.Fly && 
                (Player & Perks.SuperStrength) == Perks.SuperStrength)
                {
                    //You have flying radiation
                    Console.WriteLine("Flying Radiation!");
                }
                Console.WriteLine("Press enter to continue/exit");
                Console.ReadLine()
            }

            

        }


    }
}