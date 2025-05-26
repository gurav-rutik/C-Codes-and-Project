using System.Diagnostics;

namespace DebugException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            try
            {
                int num1 = 10;
                int num2 = 0;
                result = num1 / num2;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());

                //this next line is only executed during 'Debugging"
                Debug.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Result : "+result);
            }

            Console.ReadKey();
        }
    }
}
