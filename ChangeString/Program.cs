using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write sentence here
            String header = Console.ReadLine();

            //Write letter here
            string remove = Console.ReadLine();
            //Converts letter into char
            char character = char.Parse(remove);

            //Write sentence
            Console.WriteLine(header);
            //Write sentence with char removed
            Console.WriteLine(header.Trim( new Char[] { character } ));
            //Test
        }
    }
}
