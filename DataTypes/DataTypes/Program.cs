using System;

namespace DataTypes
{
    class DataType
    {
        public static void Main(string[] args)
        {
            byte b = 1;
            short s = 12;
            int i = 12345;
            long l = 12344568694726;
            float f = 244.5f;
            double d = 245.3636266;
            char c = 'A';
            bool t = true;
            int a = 0010;

            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(t);
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}