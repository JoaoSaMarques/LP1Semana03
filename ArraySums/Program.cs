using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write sentence here
            Console.WriteLine("Input Vertical array:");
            int Hor = int.Parse(Console.ReadLine());

            //Write
            Console.WriteLine("Input Horizontal array:");
            int Ver = int.Parse(Console.ReadLine());

            float[,] array = new float[Ver, Hor];

            for (int i = 0; i < Ver; i++)
            {
                for (int j = 0; j < Hor; j++)
                {
                    Console.WriteLine("Write the values for [{i}, {j}]: ");
                    array[i, j] = float.Parse(Console.ReadLine());
                }
            }

            //Calculate the arrays line
            for (int i = 0; i < Ver; i++)
            {
                float SumHor = 0;
                for (int j = 0; j < Hor; j++)
                {
                    SumHor += array[i, j];
                }
            }
            //Calculate the arrays in each column
            for (int j = 0; j < Hor; j++)
            {
                float SumVer = 0;
                for (int i = 0; i < Ver; i++)
                {
                    SumVer += array[i, j];
                }
            }
            Console.ReadLine();

        }
    }
}

