using System;

namespace Exercise
{
    public class Exercise
    {
        public static void Main(string[] args)
        {

            Exercise exercise = new Exercise();
            exercise.SimpleCalculator();
        }
        public void SimpleCalculator()
        {
            Console.WriteLine("Enter first number : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose Arithmetic operation : +,-,*,/");
            char ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case '+': Console.WriteLine(num1 + num2); break;
                case '-': Console.WriteLine(num1 - num2); break;
                case '*': Console.WriteLine(num1 * num2); break;
                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                default: Console.WriteLine("invalid operation. Please choose +,-,*, or /."); break;
            }

            Console.ReadKey();
        }
    }
}
