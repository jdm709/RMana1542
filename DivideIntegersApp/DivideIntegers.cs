using System;

public class DivideIntegers
{
    public static string Divide(string numeratorStr, string denominatorStr)
    {
        try
        {
            int numerator = int.Parse(numeratorStr);
            int denominator = int.Parse(denominatorStr);
            int result = numerator / denominator;
            return $"Result: {result}";
        }
        catch (FormatException)
        {
            return "Error: Please enter valid integers.";
        }
        catch (DivideByZeroException)
        {
            return "Error: Division by zero is not allowed.";
        }
    }
}