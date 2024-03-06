using System;

namespace PowTwoUntil
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args">it will go through and call the methods</param>
        static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();
            PowersOf2UntilN(5); 
            PowersOf2UntilN(3); 
        }

        /// <summary>
        /// 
        /// </summary>
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(5);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Write until it reaches number n</param>
        private static void PowersOf2UntilN(int n)
        {
            for(int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
