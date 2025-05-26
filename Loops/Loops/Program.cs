namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "My name is Rutik!!";

            for(int i = 0; i < name.Length; i++)
            {
                char c = name[i];

                Console.Write(c);

                Thread.Sleep(1000);
            }

            Console.ReadKey();
        }
    }
}
