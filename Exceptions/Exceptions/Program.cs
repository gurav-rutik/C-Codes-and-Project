namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;
            try
            {
                int num1 = 10;
                int num2 = 0;

                 Result = num1 / num2;
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : "+ex.Message);
            }
            finally
            {
                Console.WriteLine("Result : " + Result);
            }

            Console.ReadKey();
        }
    }
}
