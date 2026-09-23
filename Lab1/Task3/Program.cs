using System;
using System.Collections.Generic;

class StackDemo
{
    static void Main()
    {
        Stack<string> myStack = new Stack<string>();

        while (true)
        {
            Console.WriteLine("\n--- STACK OPERATIONS ---");
            Console.WriteLine("1 - Add item");
            Console.WriteLine("2 - Remove item");
            Console.WriteLine("3 - View top");
            Console.WriteLine("4 - Show stack");
            Console.WriteLine("0 - Close program");
            Console.Write("Select an option: ");

            string? option = Console.ReadLine();

            if (option == "0")
            {
                Console.WriteLine("Program closed.");
                break;
            }

            switch (option)
            {
                case "1":
                    Console.Write("Enter an item: ");
                    string? input = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        myStack.Push(input);
                        Console.WriteLine("Item added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("You cannot add an empty item.");
                    }

                    break;

                case "2":
                    if (myStack.TryPop(out string? deletedItem))
                    {
                        Console.WriteLine($"Removed: {deletedItem}");
                    }
                    else
                    {
                        Console.WriteLine("The stack is empty.");
                    }

                    break;

                case "3":
                    if (myStack.TryPeek(out string? firstItem))
                    {
                        Console.WriteLine($"Top item: {firstItem}");
                    }
                    else
                    {
                        Console.WriteLine("The stack is empty.");
                    }

                    break;

                case "4":
                    if (myStack.Count == 0)
                    {
                        Console.WriteLine("Nothing to display.");
                    }
                    else
                    {
                        Console.WriteLine("\nCurrent stack:");

                        foreach (var element in myStack)
                        {
                            Console.WriteLine($"-> {element}");
                        }
                    }

                    break;

                default:
                    Console.WriteLine("Please select a valid option.");
                    break;
            }
        }
    }
}
