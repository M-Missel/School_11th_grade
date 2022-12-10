using System;

namespace while_loops_Tasks_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iresult = 0;
            int icontrolvariable = 0;
            Random random = new Random();

            while (icontrolvariable != 6)
            {
                icontrolvariable = random.Next(1,7);
                iresult += icontrolvariable;

                Console.WriteLine("diced number: {0}", icontrolvariable);
            }

            Console.WriteLine("Sum: {0}", iresult);
        }
    }
}
