using System;

namespace Array_2D_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ints = new int[5, 5];
            int searchNumber = 55;


            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int k = 0; k < ints.GetLength(0); k++)
                {
                    ints[i, k] = -1;
                }
            }

            ints[2, 2] = searchNumber;

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int k = 0; k < ints.GetLength(0); k++)
                {
                    if (ints[i,k] == searchNumber)
                    {
                        Console.WriteLine($"The Number is in the Field {i} | {k}");
                        break;
                    }
                }
            }


        }
    }
}
