using System;

public class RectangleArea
{
    public static void Main(string[] args)
    {
        // Get length and width from the user
        Console.WriteLine("Enter the length of the rectangle:");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the width of the rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());

        // Calculate the area
        double area = length * width;

        // Display the area
        Console.WriteLine("The area of the rectangle is: {0}", area);
    }
}
