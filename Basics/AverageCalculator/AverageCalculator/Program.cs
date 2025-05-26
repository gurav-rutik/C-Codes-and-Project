namespace AverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int counter = 0;
            int marks = 0;

            do
            {
                Console.WriteLine("Enter students marks. Enter -1 to finish : ");
                marks = int.Parse(Console.ReadLine());

                if (marks != -1)
                {
                    sum += marks;
                    counter++;
                }

            } while (marks != -1);

            Console.WriteLine("\nThe average is : "+(sum/counter));

            Console.ReadKey();
        }
    }
}
