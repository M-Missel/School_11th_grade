using System;

namespace while_loops_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char breakout = 'Y';
            int ia = 0;
            int ib = 0;

            while (breakout == 0x59 || breakout == 0x79)
            {
                Console.Write("Enter the first Number: ");
                ia = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second Number");
                ib = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The Result of {0} + {1} = {2}", ia, ib, calcAdd(ia, ib));

                Console.Write("Restart the Programm? (Y/N): ");
                breakout = Convert.ToChar(Console.ReadLine());
            }
        }

        static int calcAdd(int ia, int ib)
        {
            return ia + ib;
        }
    }
}
