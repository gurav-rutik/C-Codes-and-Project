namespace DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Type casting

            byte b = 10;
            short s = b;
            int i = s;
            long l = i;
            float f = l;
            double d = l;
            Console.WriteLine(d);

            int num1 = 12, num2=13;

            double result = num1 + num2;

            result = Math.Round(result, 2);
            Console.WriteLine(result);

            // Explicit Type casting

            double d1 = 123.1435352324;

            float f1 = (float) d1;

            Console.WriteLine(d1);
            Console.WriteLine(f1);

            long l1 = 5473798118635371812;
            int i2 = (int)l1;

            Console.WriteLine(l1);
            Console.WriteLine(i2);

            Console.ReadKey();
        }
    }
}
