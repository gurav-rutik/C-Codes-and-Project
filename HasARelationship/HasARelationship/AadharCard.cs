using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HasARelationship
{
    class AadharCard
    {
        long aadharNumber;
        string dob;
        string address;

        public AadharCard(long aadharNumber, string dob, string address)
        {
            this.aadharNumber = aadharNumber;
            this.dob = dob;
            this.address = address;
        }

        public void DisplayDetails()
        {
        
            Console.WriteLine("AadharNumber : "+aadharNumber+", DOB : "+dob+", Address : "+address);
        }
    }
}
