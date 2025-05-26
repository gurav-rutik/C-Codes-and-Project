using System;

namespace PrivateAccess
{
    class PrivateAccess
    {
        private int a;

        public PrivateAccess(int a)
        {
            this.a = a;
        }

        public void DisplayData()
        {
            Console.WriteLine(a);
        }
        public static void Main(string[] args)
        {
            PrivateAccess  privateAccess = new PrivateAccess(1);
            privateAccess.DisplayData();

            

            privateAccess.a = 20;
            privateAccess.DisplayData();


            Console.ReadKey();
        }
    }
}
