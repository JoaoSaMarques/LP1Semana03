using System;

namespace PlayerAchievements
{
    [Flags]
    internal enum Achievements
    {
        DefeatOptionalBoss = 1
        FindHiddenLevel = 2
        FinishGame = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            Achievements achievements = 0

            Console.WriteLine("Please input the number of players.")
            int n = Console.ReadLine()
        }
    }
}
