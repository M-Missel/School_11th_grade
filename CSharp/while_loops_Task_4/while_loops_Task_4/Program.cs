using System;

namespace while_loops_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dKWasserTemp = 75;
            int iMinuten = 0;

            while (dKWasserTemp >= 2.01)
            {
                iMinuten++;

                dKWasserTemp -= CalcDif(dKWasserTemp);
            }

            Console.WriteLine(iMinuten);
        }

        static double CalcDif(double dKWasserTemp)
        {
            double dDif = 0;

            dDif = (dKWasserTemp - 2) / 10;

            return dDif;
        }
    }
}
