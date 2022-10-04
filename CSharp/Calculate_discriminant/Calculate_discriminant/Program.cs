using System;

namespace Calculate_discriminant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Integer for a ");
            int iInputA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a Integer for b ");
            int iInputB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a Integer for c: ");
            int iInputC = Convert.ToInt32(Console.ReadLine());

            double dDiscriminant = discriminant(iInputA, iInputB, iInputC);

            if (dDiscriminant > 0)
            {
                Console.WriteLine("Has two zero points: X1 {0} and X2 {1}", x1Value(iInputA, iInputB, iInputC), x2Value(iInputA, iInputB, iInputC));

            }
            else if (dDiscriminant == 0)
            {
                Console.WriteLine("Has one zero point: X1 {0}", x1Value(iInputA, iInputB, iInputC));
            }
            else
            {
                Console.WriteLine("Has no zero points");
            }

            Console.ReadKey();
        }

        static double x1Value(int iInputA, int iInputB, int iInputC)
        {
            double xValue = 0;

            xValue = (-iInputB - Math.Sqrt(Math.Pow(iInputB, 2) - 4 * iInputA * iInputC)) / (2 * iInputA);

            return xValue;
        }

        static double x2Value(int iInputA, int iInputB, int iInputC)
        {
            double xValue = 0;

            xValue = (-iInputB + Math.Sqrt(Math.Pow(iInputB, 2) - 4 * iInputA * iInputC)) / (2 * iInputA);

            return xValue;
        }

        static double discriminant(int iInputA, int iInputB, int iInputC)
        {
            double dDiscriminant = 0;

            dDiscriminant = Math.Pow(iInputB, 2) - 4 * iInputA * iInputC;

            return dDiscriminant;
        }
    }
}
