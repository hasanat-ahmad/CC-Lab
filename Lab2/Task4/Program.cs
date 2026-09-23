using System;
using System.Text.RegularExpressions;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 4: All Operators (Logical, Relational, Arithmetic)");
            Console.Write("Enter input: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            Regex logicalRegex = new Regex(@"^(&&|\|\||!)$");
            Regex relationalRegex = new Regex(@"^([<>!=]=|[<>])$");
            Regex arithmeticRegex = new Regex(@"^(\+|-|\*|/|%)$");

            Console.WriteLine();
            Console.WriteLine("+------------+------------+");
            Console.WriteLine("| Token      | Category   |");
            Console.WriteLine("+------------+------------+");

            for (int i = 0; i < words.Length; i++)
            {
                Match logicalMatch = logicalRegex.Match(words[i]);
                Match relationalMatch = relationalRegex.Match(words[i]);
                Match arithmeticMatch = arithmeticRegex.Match(words[i]);

                if (logicalMatch.Success)
                {
                    Console.WriteLine("| {0,-10} | {1,-10} |", words[i], "Logical");
                }
                else if (relationalMatch.Success)
                {
                    Console.WriteLine("| {0,-10} | {1,-10} |", words[i], "Relational");
                }
                else if (arithmeticMatch.Success)
                {
                    Console.WriteLine("| {0,-10} | {1,-10} |", words[i], "Arithmetic");
                }
                else
                {
                    Console.WriteLine("| {0,-10} | {1,-10} |", words[i], "Invalid");
                }
            }

            Console.WriteLine("+------------+------------+");
        }
    }
}
