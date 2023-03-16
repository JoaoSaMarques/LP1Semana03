using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //int[] array = { 1, 2, 3, 4, 5 };
 
            //int sum = 0;
            //Array.ForEach(array, i => sum += i);
 
            //Console.WriteLine(sum);

            string[] str = { "1.23", "0.45", "123.4322" };
            float[] flt = new float[str.Length];

            for (int i = 0; i < str.Length; i++)
            flt[i] = float.Parse(str[i]);

            Console.WriteLine(str);
            
        }
    }
}
