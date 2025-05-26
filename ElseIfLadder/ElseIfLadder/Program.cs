namespace ElseIfLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            float marks = 85.40f;

            if(marks < 35)
            {
                Console.WriteLine("Your fail!!");
            }else if(marks >=35 && marks <= 50)
            {
                Console.WriteLine("Your Grade is : F");
            }
            else if (marks >= 50 && marks <= 60)
            {
                Console.WriteLine("Your Grade is : E");
            }
            else if (marks >= 60 && marks <= 70)
            {
                Console.WriteLine("Your Grade is : D");
            }
            else if (marks >= 70 && marks <= 80)
            {
                Console.WriteLine("Your Grade is : C");
            }
            else if (marks >= 80 && marks <= 90)
            {
                Console.WriteLine("Your Grade is : B");
            }
            else
            {
                Console.WriteLine("Your Grade is : A");
            }

            Console.ReadKey();
        }
    }
}
