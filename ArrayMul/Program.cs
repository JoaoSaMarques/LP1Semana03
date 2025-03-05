﻿using System;

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

            float[,] A = new float[2, 2];
            float[] b = new float[2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    A[i, j] = float.Parse(args[i * 2 + j]);
                }
            }

            for (int i = 0; 1 < 2; i++)
            {
                b[i] = float.Parse(args[4 + i]);
            }
        }
    }
}
