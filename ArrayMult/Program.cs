using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 6)
            {
                Console.WriteLine("Input exactly 6 arguments");
                return;
            }

            // Matriz A e Vetor B
            float[,] A = new float[2, 2];
            float[] b = new float[2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    A[i, j] = float.Parse(args[i * 2 + j]);
                }
            }

            
        }
    }
}
