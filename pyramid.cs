using System;

public class Pyramid
{
    public static void Main(string[] args)
    {
        int rows = 5; // Change this value to adjust the height of the pyramid

        for (int i = 1; i <= rows; i++)
        {
            // Add spaces before stars for proper formatting
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
