using System;
using System.Globalization;

namespace DoubleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0.0;
            double num2 = 0.0;

            Console.WriteLine("Enter num1 : ");
            string str1 = Console.ReadLine();
            num1 = double.Parse(str1, CultureInfo.InvariantCulture);

            Console.WriteLine("Enter num2 : ");
            string str2 = Console.ReadLine();
            num2 = double.Parse(str2, CultureInfo.InvariantCulture);

            double sum = num1 + num2;
            sum = Math.Round(sum, 2);

            Console.WriteLine($"The sum of {num1} and {num2} is : {sum}");

            Console.ReadKey();
        }
    }
}
