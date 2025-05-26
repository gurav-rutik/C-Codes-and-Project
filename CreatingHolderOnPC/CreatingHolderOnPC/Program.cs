namespace CreatingHolderOnPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");

            if(!File.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, "Hello Rutik!!"+"\n");
            Console.ReadKey();
        }
    }
}
