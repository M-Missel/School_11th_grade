/*
    Own Suggestion
    Shorter way to handle this problem
    No cover up for edge cases --> Only for multiplications
*/
int idouble, idoubleOutput;

Console.Write("Programm: Zahlen verdoppeln\n\nBitte geben Sie eine Zahl ein: ");
idouble = Convert.ToInt32(Console.ReadLine());

idoubleOutput = idouble << 1;

Console.WriteLine("Das Doppelte von {0} ist {1}", idouble, idoubleOutput);

Console.ReadKey();

/*
    Teachers Suggestion
*/

string zahlstring;
int zahl;
int doppel;

Console.WriteLine("Program: Zahlen verdoppeln");
Console.WriteLine("");
Console.Write("Bitte geben Sie eine Zahl ein: ");
zahlstring = Console.ReadLine();
zahl = Convert.ToInt32(zahlstring);
doppel = 2 * zahl;
Console.Write("Das Doppelte von ");
Console.Write(zahl);
Console.Write(" ist ");
Console.Write(Convert.ToString(doppel));