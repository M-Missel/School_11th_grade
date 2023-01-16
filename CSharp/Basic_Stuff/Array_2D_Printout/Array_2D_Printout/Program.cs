using System;

namespace Array_2D_Printout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ints = new int[5, 5];

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int k = 0; k < ints.GetLength(0); k++)
                {
                    ints[i, k] = -1;
                }
            }

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int k = 0; k < ints.GetLength(0); k++)
                {
                    Console.WriteLine(ints[i, k]);
                }
            }
        }
    }
}
