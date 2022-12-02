using System;

namespace divisor_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sControl = 'j';
            int iInput, iCount;

            Console.WriteLine("Output the Divisor of a Number\n-------------------------------");

            while (sControl == 0x4A || sControl == 0x6A)
            {
                iCount = 0;
                Console.Write("Please enter a interger Number: ");
                iInput = Convert.ToInt32(Console.ReadLine());

                for (int i = iInput; i != 0; i--)
                {
                    if (iInput % i == 0)
                    {
                        iCount++;
                        Console.WriteLine("The {0} divisor of {1} is: {2}", iCount, iInput, i);
                    }
                }

                if (iCount == 2)
                {
                    Console.WriteLine("The entered number is a prime number and divisible only by 1 and itself\n");
                }

                Console.Write("Should the program be run again? (j/n): ");

                try
                {
                    sControl = Convert.ToChar(Console.ReadLine());
                }
                catch
                {

                }
            }

            Console.WriteLine("Thank you for the usage of this Program");
        }
    }
}
