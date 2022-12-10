using System;

namespace while_loop_Euclide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ia, ib, itemp;

            Console.Write("Enter the first Number: ");
            ia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second Number: ");
            ib = Convert.ToInt32(Console.ReadLine());

            while (ib != 0)
            {
                itemp = ib;
                ib = (ia % ib);
                ia = itemp;
            }

            Console.WriteLine(ia);
        }
    }
}
