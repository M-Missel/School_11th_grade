using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte Zahl a eingeben: ");
            int iInputA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitte Zahl b eingeben: ");
            int iInputB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitte Operand +,-,* oder / eingeben: ");
            char cOperand = Convert.ToChar(Console.ReadLine());

            switch (cOperand)
            {
                case '+':
                    Console.WriteLine("Das Ergebnis lautet: {0} + {1} = {2}", iInputA, iInputB, iInputA + iInputB);
                    break;
                case '-':
                    Console.WriteLine("Das Ergebnis lautet: {0} - {1} = {2}", iInputA, iInputB, iInputA - iInputB);
                    break;
                case '*':
                    Console.WriteLine("Das Ergebnis lautet: {0} * {1} = {2}", iInputA, iInputB, iInputA * iInputB);
                    break;
                case '/':
                    Console.WriteLine("Das Ergebnis lautet: {0} / {1} = {2}", iInputA, iInputB, iInputA / iInputB);
                    break;
                default:
                    Console.WriteLine("Kein passenden Operator gefunden!");
                    break;
            }
        }
    }
}
