namespace Exception1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            Console.WriteLine("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter num2 : ");
             int num2 = int.Parse(Console.ReadLine());

            try
            {
               
                result = num1 / num2;
            }catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString);
            }
            finally
            {
                Console.WriteLine("Result : "+result);
            }

            Console.ReadKey();
        }
    }
}
