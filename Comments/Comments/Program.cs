using System;

namespace Comments
{
    class Comment
    {
        public static void Main(string[] args)
        {
            // Single Line Comments
            // we are assigning 1 value to a
            int a = 1;

            // Multi-Line Comments
            /*We adding a with 5*/
            int b = a + 5;

            int sum = printSum(a, b);


        }

        // XML documentation comment
        ///<summary>
            ///Retuning the sum of a and b
            ///</summary>
        public static int printSum(int a, int b)
        {
            return a + b;
        }
    }
}