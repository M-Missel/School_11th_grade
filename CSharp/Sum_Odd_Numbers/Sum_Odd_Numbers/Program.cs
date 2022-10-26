using System;

namespace Sum_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iOutput = 0;

            Console.Write("Enter an odd Number: ");
            int iOdd = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= iOdd; i+=2)
            {
                iOutput = iOutput + i;
            }

            Console.WriteLine("The Sum of all odd numbers between 1 and {0} is: {1}", iOdd, iOutput);

            Console.ReadKey();
        }
    }
}
