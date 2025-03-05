using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("String:");
            string s = Console.ReadLine();

            Console.WriteLine("Caráter:");
            char c = char.Parse(Console.ReadLine());

            string result = "";

            foreach (char c2 in s)
            {
                if (c2 == c)
                {
                    // Replace character with "x"
                    result += 'x';
                }

                else
                {
                    // Keep the original character
                    result += c2;
                }

                // Print modified version
                Console.WriteLine($"Será impresso: {result}");

            }
        }
    }
}
