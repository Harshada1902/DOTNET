using System;

public class PolynomialEvaluator
{
    public static double EvaluatePolynomial(double[] coefficients, double x)
    {
        double result = 0;
        for (int i = 0; i < coefficients.Length; i++)
        {
            result += coefficients[i] * Math.Pow(x, i);
        }
        return result;
    }

    public static void Main(string[] args)
    {
        // Example coefficients for a quadratic (ax^2 + bx + c)
        double[] coeffs = { 2, 3, 1 }; // a = 2, b = 3, c = 1

        Console.WriteLine("Enter a value for x:");
        double x = Convert.ToDouble(Console.ReadLine());

        // Evaluate the polynomial at the given x
        double y = EvaluatePolynomial(coeffs, x);

        Console.WriteLine("The value of the polynomial at x = {0} is: {1}", x, y);
    }
}
