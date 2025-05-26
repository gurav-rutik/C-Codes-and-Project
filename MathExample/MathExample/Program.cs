namespace MathExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Ceiling(15.3));

            Console.WriteLine(Math.Floor(15.3));

            int num1 = 23;
            int num2 = 27;

            Console.WriteLine("The Min of {0} and {1} is : {2}",num1,num2,Math.Min(num1,num2));
            Console.WriteLine("The Max of {0} and {1} is : {2}",num1,num2,Math.Max(num1,num2));

            int num3 = 16;

            Console.WriteLine("The square root of {0} is : {1}",num3, Math.Sqrt(num3));

            double num4 = 24.55;
            Console.WriteLine("the round figure of {0} is : {1}",num4, Math.Round(num4));

            int num5 = 3;
            Console.WriteLine("The power of {0} is : {1}",num5, Math.Pow(num5,num5));

            Console.WriteLine("PI : "+Math.PI);
            Console.ReadKey();
        }
    }
}
