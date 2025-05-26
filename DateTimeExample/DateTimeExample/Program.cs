
using System;

namespace DateTimeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2002, 04, 15);

            Console.WriteLine("My Birth Date is : "+date);

            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);


            DateTime tomorrow = GetTomorrow();
            Console.WriteLine(tomorrow);

            Console.WriteLine("Today is : "+DateTime.Today.DayOfWeek);

            Console.ReadKey();
        }

        public static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
