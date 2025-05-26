namespace BaseKeywordExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.talk();

            Animal animal1 = new Dog();
            animal.talk();

           Dog dog = new Dog();
            dog.talk();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public virtual void talk()
        {
            Console.WriteLine("Animal makes sound!");
        }
    }
    class Dog : Animal
    {
        public override void talk()
        {
            base.talk();
            Console.WriteLine("Dog makes sound!");
        }
    }
}
