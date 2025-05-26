using System;

namespace CalculaorApp
{
    class CalculatorApp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=================================================================");
            Console.WriteLine("==================== SIMPLE CALCULATOR ==========================");
            Console.WriteLine("=================================================================\n");
            CalculatorApp calculatorApp = new CalculatorApp();

            Console.WriteLine("Enter the value of num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of num2 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Entetr your choice : ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Modulus");
            Console.WriteLine();

            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1: calculatorApp.Addition(num1, num2); break;
                case 2: calculatorApp.Subtraction(num1, num2); break;
                case 3: calculatorApp.Multiplication(num1, num2); break;
                case 4: calculatorApp.Division(num1, num2); break;
                case 5: calculatorApp.Modulus(num1, num2); break;

                default: Console.WriteLine("invalid choice !!"); ; break;
            }

            Console.ReadKey();

        }

        public void Addition(int num1, int num2)
        {
            Console.WriteLine("\nThe Addition of " + num1 + " + " + num2 + " is : " + (num1 + num2));
        }

        public void Subtraction(int num1, int num2)
        {
            Console.WriteLine("\nThe Subtraction of " + num1 + " - " + num2 + " is : " + (num1 - num2));
        }

        public void Multiplication(int num1, int num2)
        {
            Console.WriteLine("\nThe Multiplication of " + num1 + " * " + num2 + " is : " + (num1 * num2));
        }

        public void Division(int num1, int num2)
        {
            Console.WriteLine("\nThe Division of " + num1 + " / " + num2 + " is : " + (num1 / num2));
        }

        public void Modulus(int num1, int num2)
        {
            Console.WriteLine("\nThe Modulus of " + num1 + " % " + num2 + " is : " + (num1 % num2));
        }
    }

    
}