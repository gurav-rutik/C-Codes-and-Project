namespace DelegateExample
{
    
    internal class Program
    {
        //declaration
        public delegate void Notify(string mesage);
        static void Main(string[] args)
        {
            //instantiation
            Notify notifyDelegate = ShowMessage;

            //invocation
            notifyDelegate("Hello Rutik!!!");

            Console.ReadKey();

        }

        public static void ShowMessage(string mesage)
        {
            Console.WriteLine(mesage);
        }

    }
}
