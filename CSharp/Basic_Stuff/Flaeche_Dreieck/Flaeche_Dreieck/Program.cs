// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program zur Berechnung des Flaecheninhaltes eines Dreiecks");
Console.Write("Bitte geben Sie die Länge der Grundseite an: ");
double dGrundseite = Convert.ToDouble(Console.ReadLine());

Console.Write("Bitte geben Sie die Hoehe des Dreiecks an: ");
double dHoehe = Convert.ToDouble(Console.ReadLine());

double dOutput = 0.5 * dGrundseite * dHoehe;

Console.WriteLine("Die Dreiecksfläche betraegt {0} Flaecheneinheiten", dOutput);