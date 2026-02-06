/*
Abel Doyle
RCET 2265
Spring Semester 2026
BetterCalculator
https://github.com/abeldoyl/MultiplicationTable.git
*/

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rows = 12;
            int columns = 12;

            while (true)
            {
                Console.WriteLine("Please enter two numbers (1–20).");
                Console.Write($"Press \"Enter\" for a default 12x12 case");
                Console.WriteLine("");

                // Get row size
                Console.Write("Enter number of rows: ");
                string rowInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(rowInput))
                {
                    // Default 12x12
                    rows = 12;
                    columns = 12;
                    break;
                }

                if (!int.TryParse(rowInput, out rows) || rows < 1 || rows > 20)
                {
                    Console.WriteLine("Invalid row size. Try again.\n");
                    continue;
                }

                // Get column size
                Console.Write("Enter number of columns: ");
                string columnInput = Console.ReadLine();

                if (!int.TryParse(columnInput, out columns) || columns < 1 || columns > 20)
                {
                    Console.WriteLine("Invalid column size. Try again.\n");
                    continue;
                }

                break; // both inputs valid
            }

            Console.WriteLine();

            // Create multiplication table
            for (int row = 1; row <= rows; row++)
            {
                for (int column = 1; column <= columns; column++)
                {
                    Console.Write((row * column).ToString().PadLeft(5));
                }
                Console.WriteLine();
            }

            // Pause
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
        
    }
}
