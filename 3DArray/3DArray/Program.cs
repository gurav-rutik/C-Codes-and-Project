namespace _3DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];

            Console.WriteLine("Enter 3D array elements : ");
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    
                        arr[i, j] = int.Parse(Console.ReadLine());
                    
                }
            }

            Console.WriteLine("\n3D array : \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    
                        Console.Write(arr[i,j]+"  ");
                   
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
