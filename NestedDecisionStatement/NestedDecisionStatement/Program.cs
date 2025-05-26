namespace NestedDecisionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of \"a\" : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of \"b\" : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of \"c\" : ");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("\na is Largest!!");
                }
                else
                {
                    Console.WriteLine("\nc is Largest!!");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("\nb is Largest!!");
                }
                else
                {
                    Console.WriteLine("\nc is Largest!!");
                }
            }

            Console.ReadKey();
        }
    }
}
