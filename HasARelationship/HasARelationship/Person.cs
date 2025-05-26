using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasARelationship
{
    class Person
    {
        private AadharCard aadharCard = new AadharCard(295681077244, "15/04/2002", "Kolhapur");
        string name;
        string email;
        long mobile;


        public Person(string name, string email, long mobile)
        {
            this.name = name;
            this.email = email;
            this.mobile = mobile;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Name : "+name+", Email : "+email+", Mobile : "+mobile);
            aadharCard.DisplayDetails();
        }
    }
}
