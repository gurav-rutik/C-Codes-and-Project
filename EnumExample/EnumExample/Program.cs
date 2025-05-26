namespace EnumExample
{
    public enum Day{
        Sun, Mon, Tue, Web, Thru, Fri, Sat
    };

    public enum Months
    {
        Jan, Feb, Mar, Apr, May, Jun, July, Aug, Sep, Oct, Nov, Dec
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            Day fri = Day.Fri;
            Day mon = Day.Mon;

            Day day = Day.Fri;

            Console.WriteLine(day == fri);
            Console.WriteLine(Day.Mon);
            Console.WriteLine((int)Day.Mon);

            Console.WriteLine(Months.Apr);
            Console.WriteLine((int)Months.Jun);

            Console.ReadKey();
        }
    }
}
