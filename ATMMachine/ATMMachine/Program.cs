using System;

namespace ATMMachine
{
    class ATMMachine
    {
        public static void Main(string[] args)
        {
            int pin = 1010;
            double amount = 2000;

            Console.WriteLine("Enter your pin : ");
            int pinNo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (pin == pinNo)
            {

                Console.WriteLine("===============================================");
                Console.WriteLine("*******        Welcome to ATM !!        *******");
                Console.WriteLine("===============================================\n");

                Console.WriteLine("Enter\n");
                Console.WriteLine("1. Deposite");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");

                Console.WriteLine();
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1: 
                        Console.WriteLine("Enter Deposite amount : ");
                        double depositeAmt = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if(amount>0 && depositeAmt <= amount)
                        {
                            amount -= depositeAmt;

                            Console.WriteLine($"\nTotal balance : {amount}\n");
                        }
                        else
                        {
                            Console.WriteLine("Insuffient amount !!\n");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter Withdraw amount : ");
                        double withdrawAmt = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (withdrawAmt > 0)
                        {
                            amount += withdrawAmt;

                            Console.WriteLine($"\nTotal balance : {amount}\n" );
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount, please enter valid amount !!\n");
                        }
                        break;

                    case 3:
                        Console.WriteLine($"Total Balance is : {amount}\n");
                        break;

                    default: Console.WriteLine("Invalid choice !!");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Invalid Pin please enter valid pin !!\n");
            }

            Console.WriteLine("===============================================");
            Console.WriteLine("*******         Thank you !!            *******");
            Console.WriteLine("===============================================");

            Console.ReadKey();
        }
    }
}