namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];

            arr[0] = new int[] { 1, 2, 3 };
            arr[1] = new int[] { 4, 5 };
            arr[2] = new int[] { 6, 7, 8, 9 };

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(i+": ");
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
