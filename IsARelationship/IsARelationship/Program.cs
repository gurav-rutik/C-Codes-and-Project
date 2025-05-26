namespace IsARelationship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer("Rutik", "rutik@gmail.com", 9011715158, 1323, "JSE");
            developer.DisplayDetails();

            Console.ReadKey();
                 
        }
    }
}
