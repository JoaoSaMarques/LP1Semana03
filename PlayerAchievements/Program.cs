using System;

namespace PlayerAchievements
{
    [Flags]
    internal enum Achievements
    {
        DefeatOptionalBoss = 1,
        FindHiddenLevel = 2,
        FinishGame = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number of players:");
            int n = int.Parse(Console.ReadLine());

            Achievements[] AchArray = new Achievements[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Player {i + 1}: achievements (D, F, G):");
                // To upper will change lowercase to uppercase for consistency
                string input = Console.ReadLine().ToUpper();

                Achievements playerAchievements = 0;

                foreach (char t in input)
                {
                    switch (t)
                    {
                        case 'D':
                            playerAchievements 
                            |= Achievements.DefeatOptionalBoss;
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
            }

            // For each player, print their achievements
            for (int i = 0; i < n; i++)
            {
                // Check Completionist status
                if (AchArray[i] == (Achievements.DefeatOptionalBoss 
                | Achievements.FindHiddenLevel | Achievements.FinishGame))
                {
                    Console.WriteLine($"Player{i + 1} " 
                    + $"Achievements:{AchArray[i]}"
                    + " You are a true Completionist!");
                }

                else
                {
                    Console.WriteLine($"Player{i + 1} "
                    + $"Achievements:{AchArray[i]}");
                }
            }
        }
    }
}

