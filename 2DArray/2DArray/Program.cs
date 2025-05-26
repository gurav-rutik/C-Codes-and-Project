namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[2, 2];

            int[,] arr1 = { { 1, 2 }, { 3, 4 } };

            //Console.WriteLine(arr1[0,0]);

            for (int i = 0; i < arr1.GetLength(0); i++) // rows
            {
               for(int j=0;j< arr1.GetLength(1); j++) // columns
                {
                    Console.Write(arr1[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("==========================================================");
            int[,] arr2 = new int[2, 2];

            Console.WriteLine("Enter two dimensional array element : ");
            for(int i = 0; i < arr2.GetLength(0); i++)
            {
                for(int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Two dimensional array : ");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i,j]+"  ");
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
