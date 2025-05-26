namespace DictionaryExample2
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(101, new Employee("Rutik", 23, 100));
            employees.Add(102, new Employee("Pratik", 16, 200));
            employees.Add(103, new Employee("Rohan", 27, 300));
            employees.Add(104, new Employee("Digambar", 25, 400));

            foreach(KeyValuePair<int, Employee> employee in employees)
            {
                Console.WriteLine($"Id : {employee.Key}, Name : {employee.Value.Name}, Age : {employee.Value.Age}, Salary : {employee.Value.Salary}");
            }
            Console.WriteLine();

            foreach (var employee in employees)
            {
                Console.WriteLine($"Id : {employee.Key}, Name : {employee.Value.Name}, Age : {employee.Value.Age}, Salary : {employee.Value.Salary}");
            }

            Console.ReadKey();

        }
    }
}
