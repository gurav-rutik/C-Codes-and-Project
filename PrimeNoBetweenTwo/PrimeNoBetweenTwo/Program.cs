using System;

namespace PrimeNoBetweenTwo
{
    class PrimeNoBetweenTwo
    {
        
        public static void Main(string[] args)
        {
            int count = 0;

            for (int i =2;i<=10;i++)
            {
                if(IsPrime(i))
                {
                    Console.Write(i + ",");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total count " + count);
            Console.ReadKey();
        }

        public static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}