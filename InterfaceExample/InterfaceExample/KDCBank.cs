using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class KDCBank:IBankAccount
    {
        public void BankName()
        {
            Console.WriteLine("Bank Name is : KDC Bank");
        }

        public double RateOfInterest()
        {
            return 7.9;
        }
    }
}
