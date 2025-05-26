using System;

namespace ReverseWord
{
    class ReverseWord
    {
        public static void Main(string[] args)
        {
            string s = "C# is a programming language";
            string[] str = s.Split(" ");
            string rev = "";

            for(int i = str.Length-1; i >= 0; i--)
            {
                rev = rev + " " + str[i];
            }

            rev = rev.Trim();

            Console.WriteLine(rev);

            Console.ReadKey();
        }
    }
}