using System;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2: Single Regular Expression for 8e4, 5e-2, 6e9");
            Console.Write("Enter input: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                // sample input used when nothing is typed
                input = "8e4 5e-2 6e9 3e+7 12e34 e5 5e 7.2e3";
                Console.WriteLine("(no input given, using sample: " + input + ")");
            }

            string[] words = input.Split(' ');

            // digits, then e, then an optional sign, then digits
            Regex regex = new Regex(@"^[0-9]+[e][+-]?[0-9]+$");

            Console.WriteLine();
            Console.WriteLine("+------------+----------------------+");
            Console.WriteLine("| Lexeme     | Category             |");
            Console.WriteLine("+------------+----------------------+");

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 0)
                {
                    continue;
                }

                Match match = regex.Match(words[i]);
                if (match.Success)
                {
                    Console.WriteLine("| {0,-10} | {1,-20} |", words[i], "Exponent Constant");
                }
                else
                {
                    Console.WriteLine("| {0,-10} | {1,-20} |", words[i], "Invalid");
                }
            }

            Console.WriteLine("+------------+----------------------+");
        }
    }
}
