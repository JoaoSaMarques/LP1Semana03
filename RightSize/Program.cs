using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string s in args)
            {
                if (s.Length >= 8)
                {
                    // Write this if the requirements are not met
                    Console.WriteLine("[EARLY STOP]");
                    // Exit the program
                    return;
                }

                else if (s.Length > 3)
                {
                    // Write like normal
                    Console.WriteLine(s);
                }
            }
        }
    }
}
