using System;

public class TriangleArea
{
    public static void Main(string[] args)
    {
        // Get base and height from the user
        Console.WriteLine("Enter the base of the triangle:");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the triangle:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area
        double area = (baseLength * height) / 2;

        // Display the area
        Console.WriteLine("The area of the triangle is: {0}", area);
    }
}
