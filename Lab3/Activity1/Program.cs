using System;
using System.Text.RegularExpressions;

namespace Activity1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Activity 1: Constants (integers plus floating point numbers)");
            Console.Write("Enter input: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                // sample input used when nothing is typed
                input = "9 2.22211 212 8e4 5e-2 3.5e+7 if nasjk 2. .5";
                Console.WriteLine("(no input given, using sample: " + input + ")");
            }

            string[] words = input.Split(' ');

            // [0-9]+            -> the integer part (a plain integer on its own is a constant)
            // ([.][0-9]+)?      -> optional fractional part
            // ([e][+-]?[0-9]+)? -> optional exponent part
            Regex regex = new Regex(@"^[0-9]+(([.][0-9]+)?([e][+-]?[0-9]+)?)?$");

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
                    Console.WriteLine("| {0,-10} | {1,-14} |", words[i], "Constant");
                }
                else
                {
                    Console.WriteLine("| {0,-10} | {1,-14} |", words[i], "Invalid");
                }
            }

            Console.WriteLine("+------------+----------------+");
        }
    }
}
