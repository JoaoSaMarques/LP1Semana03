using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for string
            Console.WriteLine("Please input a string:");
            string s = Console.ReadLine();

            //Ask for char
            Console.WriteLine("Please input a char:");
            char c = Console.ReadKey().KeyChar;

            //Replace the letter c in string s with the letter x
            string modifiedString = s.Replace(c, 'x');
            Console.WriteLine(modifiedString);
        }
    }
}
