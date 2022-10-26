using System;

namespace Bank_Calc_Capital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dBankValue = 1000;
            int iyears = 0;
            /*
            for (int i = 0; i <= 12; i++)
            {
                dBankValue = dBankValue + dBankValue * 0.05;
            }

            Console.WriteLine("The Value of the Capital is after 12 years: {0} Euro", Math.Round(dBankValue, 2));
            */

            for (int i = 0; dBankValue <= 2000; i++)
            {
                dBankValue = dBankValue + dBankValue * 0.05;
                iyears++;
            }

            Console.WriteLine("After {0} the Bankvalue Was doubled", iyears);
        }
    }
}
