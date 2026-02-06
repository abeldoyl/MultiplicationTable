namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int size = 12; // default size
            Console.WriteLine("Please enter two numbers. Enter \"Q\" at any time to quit.");

            while (true)
            {
                // Get first number
                int row;
                if (!GetNumber(out row)) break;

                // Get second number
                int column;
                if (!GetNumber(out column)) break;
            }

            for (int row = 1; row < row + 1; row++)
            {
                for (int column = 1; column < column + 1; column++)
                {
                    Console.Write((row * column).ToString().PadLeft(3));
                }
                Console.WriteLine();


            }
                //pause
                Console.Read();
        }

        static bool GetNumber(out int number)
        {
            number = 0;

            while (true)
            {
                Console.Write("Choose a Number: ");
                string input = Console.ReadLine();

                Console.WriteLine($"You entered \"{input}\"");

                //StringComparison.OrdinalIgnoreCase is used
                //to compare strings by character value not by upper/lower case
                if (input.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
                // if (int.TryParse(input, out number)) is for seeing if the +_
                //text can be converted into a whole number,
                //if it can store it and continue, otherwise handle the error
                if (int.TryParse(input, out number))
                {
                    return true;
                }

                Console.WriteLine($"You entered \"{input}\", please enter a whole number.");
            }

        }
        
    }
}
