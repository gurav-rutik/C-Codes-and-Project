using System;

namespace CountDigits
{
    class CountDigits
    {
        public static void Main(string[] args)
        {
            int num = 12345;

            Console.WriteLine("Total Digits : " + TotalDigits(num));

            Console.ReadKey();
        }

        public static int TotalDigits(int num)
        {
            int count = 0;

            if(num == 0)
            {
                return 1;
            }
            else
            {
                while(num != 0)
                {
                    count++;
                    num /= 10;
                }
            }

            return count;
        }
    }
}