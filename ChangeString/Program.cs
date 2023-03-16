using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a sentence.");
            string sentence = Console.ReadLine();

            Console.WriteLine("Type a character to remove.");
            string ChrRem = Console.ReadLine();

            string character = sentence.Remove(ChrRem);
            

            Console.WriteLine(character);
        }
    }
}
