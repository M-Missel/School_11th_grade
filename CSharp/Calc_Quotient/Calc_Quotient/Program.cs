using System;

/*
    dInputOne = zahl
    dInputTwo = teiler
*/

namespace Calc_Quotient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie die erste Zahl ein: ");
            double dInputOne = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben Sie die zweite Zahl ein: ");
            double dInputTwo = Convert.ToDouble(Console.ReadLine());

            if (dInputTwo != 0)
            {
                double dOutput = dInputOne / dInputTwo;
                Console.WriteLine("{0} geteilt durch {1} ergibt {2}", dInputOne, dInputTwo, dOutput);
            }
            else
            {
                Console.WriteLine("Geben Sie einen anderen Teiler als 0 ein");
            }

            Console.ReadKey();
        }
    }
}
