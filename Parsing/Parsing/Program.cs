namespace TypeConversion
{
    class TypeConversion
    {
        static void Main(string[] args)
        {
            // By Parsing

            string str1 = "100";
            int num1 = int.Parse(str1);
            Console.WriteLine(num1);

            string str2 = "100.00";
            float num2 = float.Parse(str2);
            Console.WriteLine(num2);

            string str3 = "true";
            bool num3 = bool.Parse(str3);
            Console.WriteLine(num3);



            // By Convert class

            string str4 = "false";
            bool num4 = Convert.ToBoolean(str4);
            Console.WriteLine(num4);

            string str5 = "2823233892839983";
            long num5 = Convert.ToInt64(str5);
            Console.WriteLine(num5);


            // Implicitly typed variable

            var name = "Rutik";
            var age = 23;

            var n1 = 10;
            var n2 = 20;
            var n3 = n1 + n2;

            Console.WriteLine(name+" "+age);
            Console.WriteLine(n1+" "+n2+" "+n3);


            Console.ReadKey();
        }
    }
}
