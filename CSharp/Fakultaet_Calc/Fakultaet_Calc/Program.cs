using System;

namespace Fakultaet_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iInput, iOutput = 1;

            Console.Write("Geben Sie die Fakultaet ein: ");
            iInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= iInput; i++)
            {
                iOutput = iOutput * i;
            }

            Console.WriteLine("Faluktaet von {0} ist {1}",iInput, iOutput);
        }
    }
}
