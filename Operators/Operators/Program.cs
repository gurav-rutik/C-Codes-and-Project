using System;

namespace Operators
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 12, b = 13;

            //Arithmetic
            Console.WriteLine("a+b = " + (a + b));
            Console.WriteLine("a-b = " + (a - b));
            Console.WriteLine("a*b = " + (a * b));
            Console.WriteLine("a/b = " + (a / b));
            Console.WriteLine("a%b = " + (a % b));

            //Relational
            Console.WriteLine("a>b : " + (a>b));
            Console.WriteLine("a>=b : " + (a >= b));
            Console.WriteLine("a<b : " + (a < b));
            Console.WriteLine("a<b : " + (a <= b));
            Console.WriteLine("a==b : " + (a == b));

            //Logical
            Console.WriteLine("a==b && b!=a : " + (a==b && b!=a));
            Console.WriteLine("a>=b || a >=b : " + (a>=b || a >=b));
            Console.WriteLine("a != b : " + (a != b));

            //Assignment
            Console.WriteLine("a = a+b : "+ (a = a + b));
            Console.WriteLine("a +=b : "+(a += b));
            Console.WriteLine("a -=b : "+(a -= b));
            Console.WriteLine("a *=b : "+(a *= b));
            Console.WriteLine("a /=b : "+(a /= b));

            //Increment-Decrement
            Console.WriteLine(a++);
            Console.WriteLine(++a);
            Console.WriteLine(a--);
            Console.WriteLine(--a);
            Console.WriteLine(b++);
            Console.WriteLine(++b);
            Console.WriteLine(b--);
            Console.WriteLine(--b);

            //
            int message = (a > b) ? a : b;
            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
