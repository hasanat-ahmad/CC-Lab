using System;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // the document given in the lab manual
            string document =
                "Diffusion refers to the process by which molecules intermingle as a result of their kinetic " +
                "energy of random motion. Consider two containers of gas A and B separated by a partition. " +
                "The molecules of both gases are in constant motion and make numerous collisions with the " +
                "partition. If the partition is removed as in the lower illustration, the gases will mix because " +
                "of the random velocities of their molecules. In time a uniform mixture of A and B molecules " +
                "will be produced in the container. " +
                "The tendency toward diffusion is very strong even at room temperature because of the high " +
                "molecular velocities associated with the thermal energy of the particles";

            Console.WriteLine("Task 3: Words starting with 't' and 'm'");
            Console.WriteLine();

            // \b marks a word boundary, [tTmM] is the required first letter,
            // [A-Za-z]* is the rest of the word
            Regex regex = new Regex(@"\b[tTmM][A-Za-z]*\b");
            MatchCollection matches = regex.Matches(document);

            Console.WriteLine("+-------+----------------+--------------+");
            Console.WriteLine("| S.No  | Word           | Starts With  |");
            Console.WriteLine("+-------+----------------+--------------+");

            int count = 1;
            foreach (Match match in matches)
            {
                string first = match.Value.Substring(0, 1).ToLower();
                Console.WriteLine("| {0,-5} | {1,-14} | {2,-12} |", count, match.Value, first);
                count++;
            }

            Console.WriteLine("+-------+----------------+--------------+");
            Console.WriteLine("Total words found: " + matches.Count);
        }
    }
}
