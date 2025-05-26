namespace FoEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = ["Sun","Mon","Tue","Wed","Thru","Fri","Sat"];

            foreach(string day in days)
            {
                Console.WriteLine(day);
            }

            Console.ReadKey();
        }
    }
}
