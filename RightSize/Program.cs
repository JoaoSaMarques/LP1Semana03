using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string argument in args)
            {
                if (argument.Length > 3)
                {
                    Console.WriteLine(argument);
                }
            }
        }
    }
}
