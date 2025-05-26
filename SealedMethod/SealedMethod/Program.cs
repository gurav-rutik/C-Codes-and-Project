using System.ComponentModel.DataAnnotations;

namespace SealedMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.talk();

            Dog dog = new Dog();
            dog.talk();

            Cat cat = new Cat();
            cat.talk();

            Animal animal1 = new Dog();
            animal1.talk();

            Dog dog1 = new Cat();
            dog1.talk();

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
    class Dog:Animal
    {
        public sealed override void talk()
        {
            Console.WriteLine("Dog makes sound! : bow-bow");
        }
    }
    class Cat:Dog
    {
        // can't override it, because sealed

        //public override void talk()
        //{
        //    Console.WriteLine("Cat makes sound! : meow-meow");
        //}
    }
}
