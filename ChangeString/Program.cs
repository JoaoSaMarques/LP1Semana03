using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            String header = Console.ReadLine();

            string remove = Console.ReadLine();
            char character = char.Parse(remove);

            Console.WriteLine(header);
            Console.WriteLine(header.Trim( new Char[] { character } ));
        }
    }
}
