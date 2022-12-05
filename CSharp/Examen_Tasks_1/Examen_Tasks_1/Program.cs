using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tasks_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iTree_crown, iLog_size, icountSpace;

            Console.Write("Enter the size of the Tree crown: ");
            iTree_crown = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the size of the Log: ");
            iLog_size = Convert.ToInt32(Console.ReadLine());

            icountSpace = iTree_crown--;

            //Print out Tree crown

            for (int i = 1; i < iTree_crown; i++)
            {
                for (int j = icountSpace; j > 0; j--)
                {
                    Console.Write(" ");
                }

                icountSpace--;

                for (int k = 0; k != 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Print out Log

            for (int i = 0; i < iLog_size; i++)
            {
                for (int k = iTree_crown; k > 0; k--)
                {
                    Console.Write(" ");
                }
                Console.Write("***");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
