namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter choice : ");
            int choice  = int.Parse(Console.ReadLine());

            IBankAccount bankAccount = null;

            switch (choice)
            {
                case 1: bankAccount = new UnionBank(); break;
                case 2: bankAccount = new KDCBank(); break;
                default: Console.WriteLine("Invalid choice !!"); break;
            }
            if(choice == 1 || choice == 2)
            {
                bankAccount.BankName();
                Console.WriteLine("Rate of Interest is : "+bankAccount.RateOfInterest());
            }

            Console.ReadKey();
        }
    }
}
