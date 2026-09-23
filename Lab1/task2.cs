using System;

class ScientificCalculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== SCIENTIFIC CALCULATOR =====");
            Console.WriteLine("1. Sine");
            Console.WriteLine("2. Cosine");
            Console.WriteLine("3. Tangent");
            Console.WriteLine("4. Logarithm");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an operation: ");

            string? choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Calculator closed.");
                break;
            }

            Console.Write("Enter a number: ");

            if (!double.TryParse(Console.ReadLine(), out double number))
            {
                Console.WriteLine("Invalid number.");
                continue;
            }

            switch (choice)
            {
                case "1":
                    double radians = number * Math.PI / 180;
                    Console.WriteLine($"sin({number}) = {Math.Sin(radians)}");
                    break;

                case "2":
                    radians = number * Math.PI / 180;
                    Console.WriteLine($"cos({number}) = {Math.Cos(radians)}");
                    break;

                case "3":
                    radians = number * Math.PI / 180;
                    Console.WriteLine($"tan({number}) = {Math.Tan(radians)}");
                    break;

                case "4":
                    if (number > 0)
                    {
                        Console.WriteLine($"ln({number}) = {Math.Log(number)}");
                    }
                    else
                    {
                        Console.WriteLine("Log requires a number greater than 0.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}