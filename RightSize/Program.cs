using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string argument in args)
            {
                // If character length is higher than 3, write chars
                if (argument.Length > 3)
                {
                    Console.WriteLine(argument);
                }

                // If character length is higher than 6 stop
                if (argument.Length > 6)
                {
                    break;
                }
            }
        }
    }
}
