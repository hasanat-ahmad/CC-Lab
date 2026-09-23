using System;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3: Arithmetic Operators (+, -, *, /, %)");
            Console.Write("Enter input: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            Regex regex = new Regex(@"^(\+|-|\*|/|%)$");

            Console.WriteLine();
            Console.WriteLine("+------------+------------+");
            Console.WriteLine("| Token      | Category   |");
            Console.WriteLine("+------------+------------+");

            for (int i = 0; i < words.Length; i++)
            {
                Match match = regex.Match(words[i]);
                if (match.Success)
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
