using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 6)
            {
                Console.WriteLine("Please provide 6 arguments.");
                return;
            }

            // Parse the arguments into a 2x2 matrix A and a 2x1 vector b
            float[,] A = new float[2, 2];
            float[] b = new float[2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    A[i, j] = float.Parse(args[i * 2 + j]);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                b[i] = float.Parse(args[4 + i]);
            }

            // Perform the multiplication A · b
            float[] result = new float[2];
            for (int i = 0; i < 2; i++)
            {
                result[i] = 0;
                for (int j = 0; j < 2; j++)
                {
                    result[i] += A[i, j] * b[j];
                }
            }

            // Print the results
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"| {result[i]:F2} |");
            }
        }
    }
}