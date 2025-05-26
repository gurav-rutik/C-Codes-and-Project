namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 0;

            try
            {
                Console.WriteLine(num1/num2);
            }catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
