using System;

namespace PlayerAchievements
{
    /// <summary>
    /// Enumeration flags.
    /// </summary>
    [Flags]
    internal enum Achievements
    {
        DefeatOptionalBoss = 1,
        FindHiddenLevel = 2,
        FinishGame = 3
    }

    class Program
    {
        /// <summary>
        /// Main program that handles the functions
        /// </summary>
        /// <param name="args">Main component</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number of players:");
            int n = int.Parse(Console.ReadLine());

            Achievements[] AchArray = new Achievements[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Player {i + 1}: achievements (D, F, G):");
                string input = Console.ReadLine().ToUpper();

                Achievements playerAchievements = 0;

                foreach (char t in input)
                {
                    switch (t)
                    {
                        case 'D':
                            playerAchievements |= Achievements.DefeatOptionalBoss;
                            break;
                        case 'F':
                            playerAchievements |= Achievements.FindHiddenLevel;
                            break;
                        case 'G':
                            playerAchievements |= Achievements.FinishGame;
                            break;
                        default:
                            Console.WriteLine($"Invalid achievement code: {t}");
                            break;
                    }
                }

                AchArray[i] = playerAchievements;

                // Check for "Completionist" status
                if (playerAchievements == (Achievements.DefeatOptionalBoss | 
                Achievements.FindHiddenLevel | Achievements.FinishGame))
                {
                    Console.WriteLine($"Player {i + 1} is a Completionist!");
                }
            }
            
            
            // For each player, print their achievements
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Player {i + 1}Achievements: {AchArray[i]}");
            }
        }
    }
}
