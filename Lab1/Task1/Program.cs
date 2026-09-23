using System;
using System.Collections.Generic;

class DataGridView
{
    static List<string> headers = new List<string>();
    static List<string[]> rows = new List<string[]>();

    static void Main()
    {
        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 0; i < cols; i++)
        {
            Console.Write($"Enter header for column {i + 1}: ");
            headers.Add(Console.ReadLine() ?? "");
        }

        while (true)
        {
            Console.WriteLine("\n===== DATA GRID VIEW =====");
            Console.WriteLine("1. Insert Row");
            Console.WriteLine("2. Display Grid");
            Console.WriteLine("3. Delete Row");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    InsertRow();
                    break;
                case "2":
                    DisplayGrid();
                    break;
                case "3":
                    DeleteRow();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void InsertRow()
    {
        string[] row = new string[headers.Count];
        for (int i = 0; i < headers.Count; i++)
        {
            Console.Write($"  {headers[i]}: ");
            row[i] = Console.ReadLine() ?? "";
        }
        rows.Add(row);
        Console.WriteLine("Row inserted successfully.");
    }

    static void DisplayGrid()
    {
        if (rows.Count == 0)
        {
            Console.WriteLine("Grid is empty.");
            return;
        }

        int[] widths = new int[headers.Count];
        for (int i = 0; i < headers.Count; i++)
        {
            widths[i] = headers[i].Length;
            foreach (var row in rows)
            {
                if (row[i].Length > widths[i])
                    widths[i] = row[i].Length;
            }
        }

        string line = "+";
        for (int i = 0; i < headers.Count; i++)
            line += new string('-', widths[i] + 2) + "+";

        Console.WriteLine(line);

        Console.Write("|");
        for (int i = 0; i < headers.Count; i++)
            Console.Write($" {headers[i].PadRight(widths[i])} |");
        Console.WriteLine();

        Console.WriteLine(line);

        for (int r = 0; r < rows.Count; r++)
        {
            Console.Write("|");
            for (int c = 0; c < headers.Count; c++)
                Console.Write($" {rows[r][c].PadRight(widths[c])} |");
            Console.WriteLine();
        }

        Console.WriteLine(line);
        Console.WriteLine($"Total rows: {rows.Count}");
    }

    static void DeleteRow()
    {
        if (rows.Count == 0)
        {
            Console.WriteLine("Grid is empty.");
            return;
        }

        DisplayGrid();
        Console.Write("Enter row number to delete (1-" + rows.Count + "): ");

        if (int.TryParse(Console.ReadLine(), out int rowNum) && rowNum >= 1 && rowNum <= rows.Count)
        {
            rows.RemoveAt(rowNum - 1);
            Console.WriteLine("Row deleted.");
        }
        else
        {
            Console.WriteLine("Invalid row number.");
        }
    }
}
