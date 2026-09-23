using System;
using System.Text.RegularExpressions;

namespace Activity2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Activity 2: Keywords (int, float, double, char)");
            Console.Write("Enter input: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                // sample input used when nothing is typed
                input = "int njka 23 double 4345 float char intx Int";
                Console.WriteLine("(no input given, using sample: " + input + ")");
            }

            string[] words = input.Split(' ');

            // grouping with ( ) and alternation with | -- one complete word must be matched.
            // note: a character class like [int | float] would be wrong, it matches single
            // letters such as 'i', 'n', 't' in any order, not the whole keyword.
            Regex regex = new Regex(@"^(int|float|double|char)$");

            Console.WriteLine();
            Console.WriteLine("+------------+----------------+");
            Console.WriteLine("| Lexeme     | Category       |");
            Console.WriteLine("+------------+----------------+");

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 0)
                {
                    continue;
                }

                Match match = regex.Match(words[i]);
                if (match.Success)
                {
                    Console.WriteLine("| {0,-10} | {1,-14} |", words[i], "Keyword");
                }
                else
                {
                    Console.WriteLine("| {0,-10} | {1,-14} |", words[i], "Not a keyword");
                }
            }

            Console.WriteLine("+------------+----------------+");
        }
    }
}
