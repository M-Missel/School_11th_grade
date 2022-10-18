using System;

namespace Number_To_Month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Biite Monat als Zahl eingeben: ");
            int iMonat = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie das Jahr [jjjj] ein: ");
            int iJahr = Convert.ToInt32(Console.ReadLine());

            switch (iMonat)
            {
                case 1:
                    Console.WriteLine("Der Monat Januar im Jahr {0} hat 31 Tage", iJahr);
                    break;
                case 2:
                    Console.WriteLine("Der Monat Februar im Jahr {0} hat 28 (29) Tage", iJahr);
                    break;
                case 3:
                    Console.WriteLine("Der Monat März im Jahr {0} hat 31 Tage", iJahr);
                    break;
                case 4:
                    Console.WriteLine("Der Monat April im Jahr {0} hat 30 Tage", iJahr);
                    break;
                case 5:
                    Console.WriteLine("Der Monat Mai im Jahr {0} hat 31 Tage", iJahr);
                    break;
                case 6:
                    Console.WriteLine("Der Monat Juni im Jahr {0} hat 30 Tage", iJahr);
                    break;
                case 7:
                    Console.WriteLine("Der Monat Juli im Jahr {0} hat 31 Tage", iJahr);
                    break;
                case 8:
                    Console.WriteLine("Der Monat August im Jahr {0} hat 31 Tage", iJahr);
                    break;
                case 9:
                    Console.WriteLine("Der Monat September im Jahr {0} hat 30 Tage", iJahr);
                    break;
                case 10:
                    Console.WriteLine("Der Monat Oktober im Jahr {0} hat 31 Tage", iJahr);
                    break;
                case 11:
                    Console.WriteLine("Der Monat November im Jahr {0} hat 30 Tage", iJahr);
                    break;
                case 12:
                    Console.WriteLine("Der Monat Dezember im Jahr {0} hat 31 Tage", iJahr);
                    break;
                default:
                    Console.WriteLine("Dieser Monat existiert nicht");
                    break;
            }
        }
    }
}
