using System;
using System.Security.Cryptography;

namespace Check_lega_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie ihr Alter ein: ");
            int iAlter = Convert.ToInt32(Console.ReadLine());

            if (iAlter < 18)
            {
                Console.WriteLine("Der Benutzer ist unter 18 Jahre");
            }
            else
            {
                Console.WriteLine("Der Benutzer ist ueber 18 Jahre");
            }

            Console.ReadKey();
        }
    }
}
