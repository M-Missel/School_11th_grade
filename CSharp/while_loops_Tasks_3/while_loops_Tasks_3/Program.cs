using System;

namespace while_loops_Tasks_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iyear = 0;
            double iRadMaterial = 100;
            Console.WriteLine("Radioactive decay");

            while (iRadMaterial > 50)
            {
                iyear++;

                iRadMaterial = Math.Round(iRadMaterial * 0.95, 2);

                Console.WriteLine("After {0} years, {1} % are still present", iyear, iRadMaterial);
            }

            Console.WriteLine("After {0} years is more than a half is decayed", iyear);
        }
    }
}
