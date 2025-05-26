using System.Runtime;

namespace AbstractClassExample
{
    class AbstractClassExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bank Services : ");
            Console.WriteLine("1. SBI");
            Console.WriteLine("2. ICICI");

            Console.WriteLine("Enter your choice : ");
            int choice = int.Parse(Console.ReadLine());

            BankAccount ba = null;

            switch (choice)
            {
                case 1:  ba = new SBI(); break;
                case 2: ba = new ICICI(); break;
                default: Console.WriteLine("Invalid choice !!!"); break;
            }
            if(choice == 1 || choice == 2)
            {
                ba.BankName();
                Console.WriteLine("Rate of Interest is : "+ba.RateOfInterest());
            }

            Console.ReadKey();

        }
    }

    
}


