namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age : ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine($"Your age is {age}!! Your eligible for voting!!");
            }

            Console.WriteLine("Bye!!");

            Console.ReadKey();
        }
    }
}
