using System.Collections;

namespace HashtableExample
{
    class Student
    {
        public string Name
        {
            get; set;
        }

        public double Salary
        {
            get; set;
        }

        public Student(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public Student()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable employee = new Hashtable();
            employee.Add(1, new Student("Rutik Gurav", 100));
            employee.Add(2, new Student("Pratik Gurav", 200));
            employee.Add(3, new Student("Rohan Gurav", 300));
            employee.Add(4, new Student("Digambar Gurav", 400));
            employee.Add(5, new Student("Somnath Gurav", 500));


            foreach(DictionaryEntry entry in employee)
            {
                Student stu = (Student)entry.Value;
                Console.WriteLine($"Name : {stu.Name}, Salary : {stu.Salary}");
            }

            Console.ReadKey();
        }
    }
}
