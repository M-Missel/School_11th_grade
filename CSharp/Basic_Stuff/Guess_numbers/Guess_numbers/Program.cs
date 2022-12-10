using System;

/*
    Task: Convert pseudocode into code
*/

namespace Guess_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iRandom, iCount = 0, iold_difference = 100, inew_difference, iInput = 0;
            Random random = new Random();

            iRandom = random.Next(1, 101);

            Console.WriteLine("Guess my Number between 1 and 100\n\nThe distance to the number is first given as 100.");

            Console.WriteLine(iRandom);

            do
            {
                Console.Write("\t...\nPlease enter a Number: ");
                iInput = Convert.ToInt32(Console.ReadLine());

                inew_difference = Math.Abs(iRandom - iInput);

                if (inew_difference < iold_difference)
                {
                    if (inew_difference > 0)
                    {
                        Console.WriteLine("\t... -> You have approached in this round");
                    }
                }
                else
                {
                    if (inew_difference > iold_difference)
                    {
                        Console.WriteLine("\t... -> You have distanced yourself in this round");
                    }
                    else
                    {
                        Console.WriteLine("\t... -> Nothing changed");
                    }
                }
                Console.WriteLine();
                iCount++;
                iold_difference = inew_difference;
                
            } while (inew_difference != 0);

            Console.WriteLine("Congratulations\n You have guessed the number in {0} tries", iCount);

            Console.ReadKey();
        }
    }
}
