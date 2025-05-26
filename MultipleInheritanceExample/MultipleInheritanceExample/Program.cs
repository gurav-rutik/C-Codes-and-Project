namespace MultipleInheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flyable flyable = new Duck();
            Swimmable swimmable = new Duck();

            flyable.fly();
            swimmable.swim();

            Console.ReadKey();
        }
    }

    public interface Flyable
    {
        void fly();
    }

    public interface Swimmable
    {
        void swim();
    }

    class Duck: Flyable, Swimmable
    {
        public void fly()
        {
            Console.WriteLine("Duck can fly..");

        }

        public void swim()
        {
            Console.WriteLine("Duck can swim..");
        }
    }
}
