
using Coding.Exercise;
using System;
using System.Xml.Linq;

namespace Coding.Exercise
{
    public class Person
    {
        string name;
        // TODO: Declare a constructor that takes a name and prints a message
        public Person(string name)
        {
            this.name = name;
            Console.Write("Person constructor: " + this.name);
        }

       
    }

    public class Employee : Person
    {
        int id;
        // TODO: Declare a constructor that takes a name and an ID, and calls the base class constructor
        public Employee(string name, int id):base(name){
            this.id = id;
            Console.Write(" Employee constructor: "+name+" ID: "+this.id);
        }

        //public string ToString()
        //{
        //    return " " + id;
        //}
    }

    public class Exercise
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee("John Doe", 123);
            //Console.WriteLine(emp);
            Console.ReadKey();

        }
    }
}


