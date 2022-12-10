using System;

namespace Flaeche_Geometrischeformen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wollen Sie den Flaecheninhalt \n - eines Kreises (k)\n - eines Dreiecks (d)\n - eines Rechtecks (r)\nberechen?\n\nBitte k, d oder r eingeben: ");
            string sInput = Console.ReadLine();

            switch (sInput)
            {
                case "k":
                    Kreis();
                    break;
                case "d":
                    Dreieck();
                    break;
                case "r":
                    Rechteck();
                    break;
                default:
                    Console.WriteLine("False Input! Please enter a valid character");
                    break;
            }
        }

        static void Rechteck()
        {
            Console.WriteLine("Program zur Berechnung des Flaecheninhaltes eines Rechtecks");
            Console.Write("Bitte geben Sie die Laenge des Rechtecks an: ");
            double dLaenge = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bitte geben Sie die Hoehe des Rechtecks an: ");
            double dHoehe = Convert.ToDouble(Console.ReadLine());

            double dOutput = dLaenge * dHoehe;

            Console.WriteLine("Die Rechtecksflaeche betraegt {0} Flaecheneinheiten", dOutput);
        }

        static void Dreieck()
        {
            Console.WriteLine("Program zur Berechnung des Flaecheninhaltes eines Dreiecks");
            Console.Write("Bitte geben Sie die Länge der Grundseite an: ");
            double dGrundseite = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bitte geben Sie die Hoehe des Dreiecks an: ");
            double dHoehe = Convert.ToDouble(Console.ReadLine());

            double dOutput = 0.5 * dGrundseite * dHoehe;

            Console.WriteLine("Die Dreiecksfläche betraegt {0} Flaecheneinheiten", dOutput);
        }

        static void Kreis()
        {
            Console.WriteLine("Program zur Berechnung des Flaecheninhaltes eines Kreises");
            Console.Write("Bitte geben Sie den Druchmesser des Kreises an: ");
            double dDiameter = Convert.ToDouble(Console.ReadLine());

            double dOutput = Math.PI * Math.Pow(dDiameter / 2, 2);

            Console.WriteLine("Die Kreisflaeche betraegt {0} Flaecheneinheiten", dOutput);
        }
    }
}
