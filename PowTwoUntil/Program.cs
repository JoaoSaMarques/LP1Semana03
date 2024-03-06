using System;

namespace PowTwoUntil
{
    class Program
    {
        /// <summary>
        /// Main entry point of the program. Calls methods to print powers of 2.
        /// </summary>
        /// <param name="args">Command-line arguments (not used).</param>
        static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();
            PowersOf2UntilN(5); 
            PowersOf2UntilN(3); 
        }

        /// <summary>
        /// Prints powers of 2 up to the 5th power.
        /// </summary>
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(5);
        }

        /// <summary>
        /// Prints powers of 2 up to the specified exponent.
        /// </summary>
        /// <param name="n">The exponent. Prints powers of 2 up to 2^n.</param>
        private static void PowersOf2UntilN(int n)
        {
            for(int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
