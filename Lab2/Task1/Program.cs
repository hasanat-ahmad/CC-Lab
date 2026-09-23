using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: Logical Operators (&&, ||, !)");
            Console.Write("Enter input: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            Regex regex = new Regex(@"^(&&|\|\||!)$");

            Console.WriteLine();
            Console.WriteLine("+------------+----------+");
            Console.WriteLine("| Token      | Category |");
            Console.WriteLine("+------------+----------+");

            for (int i = 0; i < words.Length; i++)
            {
                Match match = regex.Match(words[i]);
                if (match.Success)
                {
                    Console.WriteLine("| {0,-10} | {1,-8} |", words[i], "Logical");
                }
                else
                {
                    Console.WriteLine("| {0,-10} | {1,-8} |", words[i], "Invalid");
                }
            }

            Console.WriteLine("+------------+----------+");
        }
    }
}
