using System;

namespace Switch_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie ihre Note ein: ");
            int iNote = Convert.ToInt32(Console.ReadLine());

            switch (iNote)
            {
                case 1:
                    Console.WriteLine("Sehr gut");
                    break;
                case 2: 
                    Console.WriteLine("gut");
                    break;
                case 3: 
                    Console.WriteLine("befriedigend");
                    break;
                case 4: 
                    Console.WriteLine("ausreichend");
                    break;
                case 5: 
                    Console.WriteLine("mangelhaft");
                    break;
                case 6: 
                    Console.WriteLine("ungenügend");
                    break;
                default:
                    Console.WriteLine("Geben Sie eine Note zwischen 1 und 6 ein!");
                    break ;
            }
        }
    }
}
