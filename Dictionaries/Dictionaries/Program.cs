using System;
using System.Collections;
using System.Collections.Generic;


namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(101, "Rutik Gurav");
            employees.Add(102, "Pratik Gurav");
            employees.Add(103, "Rohan Gurav");
            employees.Add(104, "Digambar Gurav");

            foreach(KeyValuePair<int, string> employee in employees)
            {
                Object obj = employee.Value;
                Console.WriteLine($"Id : {employee.Key}, Name : {employee.Value}");
            }

            Console.ReadKey();
        }
    }
}
