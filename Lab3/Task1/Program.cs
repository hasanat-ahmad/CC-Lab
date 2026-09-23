using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: Floating Point Numbers (total length not greater than 6)");
            Console.Write("Enter input: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                // sample input used when nothing is typed
                input = "3.14 12.345 123.45 1234.56 0.5 25 .75 9.";
                Console.WriteLine("(no input given, using sample: " + input + ")");
            }

            string[] words = input.Split(' ');

            // (?=.{1,6}$) limits the whole lexeme to at most 6 characters,
            // [0-9]+[.][0-9]+ is the floating point number itself
            Regex regex = new Regex(@"^(?=.{1,6}$)[0-9]+[.][0-9]+$");

            Console.WriteLine();
            Console.WriteLine("+------------+--------+----------------+");
            Console.WriteLine("| Lexeme     | Length | Category       |");
            Console.WriteLine("+------------+--------+----------------+");

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 0)
                {
                    continue;
                }

                Match match = regex.Match(words[i]);
                if (match.Success)
                {
                    Console.WriteLine("| {0,-10} | {1,-6} | {2,-14} |", words[i], words[i].Length, "Float");
                }
                else
                {
                    Console.WriteLine("| {0,-10} | {1,-6} | {2,-14} |", words[i], words[i].Length, "Invalid");
                }
            }

            Console.WriteLine("+------------+--------+----------------+");
        }
    }
}
