using System;

namespace DivideIntegersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the second integer:");
            string input2 = Console.ReadLine();

            DivideIntegers divider = new DivideIntegers();
            divider.Divide(input1, input2);
        }
    }
}