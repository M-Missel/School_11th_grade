using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tasks_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iDif = 0, i2Euro, i1Euro, i50Cent, i20Cent, i10Cent;
            double dAmountUser, dAmountGiven;
            string sControl = "j";

            while (sControl == "j")
            {
                //Beginn Task A
                Console.Write("Please enter the first Amount: ");
                dAmountUser = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the given Amount: ");
                dAmountGiven = Convert.ToDouble(Console.ReadLine());

                int ivar1 = Convert.ToInt32(dAmountUser * 100);
                int ivar2 = Convert.ToInt32(dAmountGiven * 100);

                iDif = ivar2 - ivar1;

                i2Euro = iDif / 200;
                iDif = iDif - i2Euro * 200;

                i1Euro = iDif / 100;
                iDif = iDif - i1Euro * 100;

                i50Cent = iDif / 50;
                iDif = iDif - i50Cent * 50;

                i20Cent = iDif / 20;
                iDif = iDif - i20Cent * 20;

                i10Cent = iDif / 10;
                iDif = iDif - i10Cent * 10;

                Console.WriteLine("Count \t2-Euro-Pieces: {0}", i2Euro);
                Console.WriteLine("Count \t1-Euro-Pieces: {0}", i1Euro);
                Console.WriteLine("Count \t50-Cent-Pieces: {0}", i50Cent);
                Console.WriteLine("Count \t20-Cent-Pieces: {0}", i20Cent);
                Console.WriteLine("Count \t10-Cent-Pieces: {0}", i10Cent);

                if (iDif != 0)
                {
                    Console.WriteLine("1, 2 or 5 cent coins are still required");
                }
                //End Task A

                //Beginn Task b
                Console.Write("Run again? (j/n): ");
                sControl = Console.ReadLine();
                while (sControl != "j")
                {
                    Console.Write("Run again? (j/n): ");
                    sControl = Console.ReadLine();
                }
                //End Task b

                //Beginn Task c
                Console.Write("Run again? (j/n): ");
                sControl = Console.ReadLine();
                //End Task c
            }

            Console.ReadKey();
        }
    }
}
