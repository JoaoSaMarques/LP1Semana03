using System;

namespace PlayerAchievements
{
    [Flags]
    internal enum Achievements
    {
        DefeatOptionalBoss = 1,
        FindHiddenLevel = 2,
        FinishGame = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number of players:");
            int n = int.Parse(Console.ReadLine());

            Achievements[] achievementArray = new Achievements[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Player {i + 1}: achievements (D, F, G):");
                string input = Console.ReadLine().ToUpper();

                Achievements playerAchievements = 0;

                foreach (char achievementCode in input)
                {
                    switch (achievementCode)
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
                            Console.WriteLine($"Invalid achievement code: {achievementCode}");
                            break;
                    }
                }

                achievementArray[i] = playerAchievements;
            }
        }
    }
}
