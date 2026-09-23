using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter relational operators separated by spaces:");
        string input = Console.ReadLine();

        string[] operators = input.Split(' ');
        Regex regex = new Regex(@"^(<|>|<=|>=|==|!=)$");

        Console.WriteLine();
        Console.WriteLine("+------------+------------+");
        Console.WriteLine("| Token      | Category   |");
        Console.WriteLine("+------------+------------+");

        foreach (string op in operators)
        {
            Match match = regex.Match(op);

            if (match.Success)
            {
                Console.WriteLine("| {0,-10} | {1,-10} |", op, "Relational");
            }
            else
            {
                Console.WriteLine("| {0,-10} | {1,-10} |", op, "Invalid");
            }
        }

        Console.WriteLine("+------------+------------+");
    }
}
