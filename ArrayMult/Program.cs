using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check if length is exactly 6
            if (args.Length != 6)
            {
                Console.WriteLine("Please input exactly 6 arguments");
                return;
            }

            // Matriz A & Vetor B
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

            // Call upon method to multiply them
            float[] result = MultiplyMatrixByVector(A, b);

            // Result of multiplication
            Console.WriteLine($"A · b = [{result[0]}, {result[1]}]");
        }

        //Multiplication process for matrix and vector
        static float[] MultiplyMatrixByVector(float[,] matrix, float[] vector)
        {
            float[] result = new float[2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i] += matrix[i, j] * vector[j];
                }
            }

            return result;
        }
    }
}
