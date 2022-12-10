using System;

namespace Flaeche_Rechteck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program zur Berechnung des Flaecheninhaltes eines Rechtecks");
            Console.Write("Bitte geben Sie die Laenge des Rechtecks an: ");
            double dLaenge = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bitte geben Sie die Hoehe des Rechtecks an: ");
            double dHoehe = Convert.ToDouble(Console.ReadLine());

            double dOutput = dLaenge * dHoehe;

            Console.WriteLine("Die Rechtecksflaeche betraegt {0} Flaecheneinheiten", dOutput);
        }
    }
}
