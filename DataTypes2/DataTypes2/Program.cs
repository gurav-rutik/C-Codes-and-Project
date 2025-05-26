using System;

namespace Datatypes2
{
    class DataTypes2
    {
        public static void Main(string[] args) 
        {
            // value types

            byte b = 255; // 1bytes --> 8 bits
            sbyte b2 = -128;

            short s = 2324; // 2bytes --> 16 bits

            int i = -1234567891; // 4bytes --> 32 bits
            uint i2 = 1313;

            long l = -12345678911234; // 8bytes --> 64 bits
            ulong l2 = 13253743483535636;

            float f = 1234.353f; //4bytes --> 128 bits

            double d = 1324.2536262626; //8bytes --> 256 bits

            char c = 'A'; // 2bytes --> 16 bits

            bool t = false; // 1bit

            Console.WriteLine(b);
            Console.WriteLine(b2);
            Console.WriteLine(s);
            Console.WriteLine(i);
            Console.WriteLine(i2);
            Console.WriteLine(l);
            Console.WriteLine(l2);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(t);

            // Reference types

            string str = "Rutik";
            Console.WriteLine(str);

            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine(null?);

            Console.ReadKey();
        }
    }
}