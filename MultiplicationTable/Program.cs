namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    Console.Write((row * column).ToString().PadLeft(3));
                }
                Console.WriteLine();

            }
        }
    }
}
