using System;

namespace NumberGuesingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int userChoice = rnd.Next(1, 101);

            int num = 0;
            int attempt = 0;

            while(num != userChoice)
            {
                Console.WriteLine("\nEnter your guess : ");
                num = int.Parse(Console.ReadLine());

                if (num < userChoice)
                {
                    Console.WriteLine("Too low! Try again!!");
                }else if(num> userChoice)
                {
                    Console.WriteLine("Too high! Try again!!");
                }
                else
                {
                    Console.WriteLine("\nYou gussed!!, it in " + attempt+" attempt!!");
                    
                }
                attempt++;
            }


            Console.ReadKey();
        }
    }
}
