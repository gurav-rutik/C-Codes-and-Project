using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class UnionBank:IBankAccount
    {
        public void BankName()
        {
            Console.WriteLine("Bank name is : Union Bank");
        }

        public double RateOfInterest()
        {
            return 6.7;
        }
    }
}
