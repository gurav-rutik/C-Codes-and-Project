namespace DictionaryExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var course = new Dictionary<string, string>
            {
                ["A"] = "C#",
                ["B"] = "Java",
                ["C"] = "Python",

            };

            //if(course.TryGetValue("Name", out string name))
            //{
            //    Console.WriteLine(name);
            //}

            foreach(var item in course)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }

            Console.ReadKey();
        }
    }
}
