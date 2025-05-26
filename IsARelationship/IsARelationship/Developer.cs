using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IsARelationship
{
    public class Developer : Employee
    {
        string position;

        public Developer(string name, string email, long mobile, double salary, string position):base(name, email, mobile,salary)
        {
            this.position = position;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            System.Console.WriteLine("Position : " + position);
        }
    }
}
