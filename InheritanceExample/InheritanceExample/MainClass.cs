using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.talk();
            dog.bark();

            Console.ReadKey();
        }
    }
}
