namespace HasARelationship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Rutik Gurav", "rutik@gmail.com", 9011715158);
            person.DisplayDetails();

            Console.ReadKey();

        }
    }
}
