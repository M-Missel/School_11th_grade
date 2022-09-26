using System;

namespace Flaeche_Kreisflaeche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program zur Berechnung des Flaecheninhaltes eines Kreises");
            Console.Write("Bitte geben Sie den Druchmesser des Kreises an: ");
            double dDiameter = Convert.ToDouble(Console.ReadLine());

            double dOutput = Math.PI * Math.Pow(dDiameter / 2, 2);

            Console.WriteLine("Die Kreisflaeche betraegt {0} Flaecheneinheiten", dOutput);
        }
    }
}
