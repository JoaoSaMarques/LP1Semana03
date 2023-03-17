using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write Horizontal Array
            Console.WriteLine("Input Vertical array:");
            int Hor = int.Parse(Console.ReadLine());

            //Write Vertical array
            Console.WriteLine("Input Horizontal array:");
            int Ver = int.Parse(Console.ReadLine());

            //Create a two-dimensional array of floats
            float[,] array = new float[Ver, Hor];

            //While [i] is smaller than Vertical number
            for (int i = 0; i < Ver; i++)
            {
                for (int j = 0; j < Hor; j++)
                {

                    Console.WriteLine("Position i and j in order.");
                    //Make Array
                    array[i, j] = float.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < Ver; i++)
            {
                float SumHor = 0;
                for (int j = 0; j < Hor; j++)
                {
                    //Sum Horizontal Array
                    SumHor += array[i, j];
                    Console.WriteLine(SumHor)
                }
            }

            for (int j = 0; j < Hor; j++)
            {
                float SumVer = 0;
                for (int i = 0; i < Ver; i++)
                {
                    //Sum Vertical Array
                    SumVer += array[i, j];
                    Console.WriteLine(SumVer)
                }
            }

        }
    }
}
