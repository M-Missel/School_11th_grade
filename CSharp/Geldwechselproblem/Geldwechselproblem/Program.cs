using System;

namespace Geldwechselproblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iInput, irest, i13Rubel;

            Console.Write("Geldbetrag: ");
            iInput = Convert.ToInt32(Console.ReadLine());

            irest = iInput % 13;
            i13Rubel = iInput / 13;

            for (int i = 1; irest % 8 != 0; i++)
            {
                i13Rubel--;
                irest += 13;
            }

            Console.WriteLine("{0} = 8 Rubel {1} = 13 Rubel", irest / 8, i13Rubel);
        }
    }
}
