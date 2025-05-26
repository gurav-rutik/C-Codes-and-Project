using System;

namespace NestedDecisionStatement2
{
    class NestedDecisionStatementPractice
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your age : ");
            int age = int.Parse(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("Go party in the club!");
            }else if (age >= 13)
            {
                Console.WriteLine("Are you with your parents? Answer Y or N : ");
                char c = char.Parse(Console.ReadLine());

                if(c == 'Y')
                {
                    Console.WriteLine("Go party in the club with your parents!");
                }
                else
                {
                    Console.WriteLine("No party for you today!");
                }
            }
            else
            {
                Console.WriteLine("Go party in kindergarten!");
            }

            Console.ReadKey();
        }
    }
}