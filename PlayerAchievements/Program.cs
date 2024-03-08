using System;

namespace PlayerAchievements
{
    [Flags]
    internal enum HeroPerks
    {
        DefeatOptionalBoss = 1
        FindHiddenLevel = 2
        FinishGame = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
