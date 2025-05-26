using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsARelationship
{
    public class Employee
    {
        string name;
        string email;
        long mobile;
        double salary;

        public Employee(string name, string email, long mobile, double salary)
        {
            this.name = name;
            this.email = email;
            this.mobile = mobile;
            this.salary = salary;
        }

        public virtual void DisplayDetails()
        {
            System.Console.WriteLine("Name : " + name);
            System.Console.WriteLine("Email : " + email);
            System.Console.WriteLine("Mobile : " + mobile);
            System.Console.WriteLine("Salary : " + salary);
        }
    }
}
