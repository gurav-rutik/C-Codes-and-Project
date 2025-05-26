namespace CallStachExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LevelOne();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Appp is still running..");
            }

            Console.ReadKey();
        }

        public static void LevelOne()
        {
            LevelTwo();

        }

        public static void LevelTwo()
        {
            Console.WriteLine("Level two before throw");
            throw new Exception("Something went wrong!!");
        }
    }
}
