namespace MethodHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog();
            animal.Hii();
            animal.Hello();

            Dog dog = new Dog();
            dog.Hii();
            dog.Hello();

            Console.ReadKey();
        }

        
    }

    class Animal
    {
        public virtual void Hii()
        {
            Console.WriteLine("Overriding -> I'm from Base class.");
        }

        public void Hello()
        {
            Console.WriteLine("Hiding -> I'm from Base class.");
        }
    }

    class Dog : Animal
    {
        public override void Hii()
        {
            Console.WriteLine("Overriding -> I'm from Derived class.");
        }

        public new void Hello()
        {
            Console.WriteLine("Hiding -> I'm from Derived class.");
        }
    }
}
