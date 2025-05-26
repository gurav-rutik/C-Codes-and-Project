
namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // assigning value to each index in array

            Console.WriteLine("assigning value to each index in array");
            int[] arr = new int[5];

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            //arr[5] = 6;

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            // Taking user input

            int[] arr2 = new int[5];

            Console.WriteLine("\nEnter array element : ");
            for(int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array elements are : ");
            for(int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            // declaring and assigning the value to an array

            Console.WriteLine("\ndeclaring and assigning the value to an array");
            int[] arr3 = { 12, 35, 14, 36, 41, 63 };

            foreach(int i in arr3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\ndeclaring and assigning the value to an array");

            int[] arr4 = [53,57,25,8,26];

            foreach(int items in arr4)
            {
                Console.WriteLine(items);
            }

            Console.WriteLine("\nString Array : ");

            string[] s = ["Rutik", "Pratik", "Rohan","Digambar"];

            for(int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

            Console.ReadKey();
        }
    }
}
