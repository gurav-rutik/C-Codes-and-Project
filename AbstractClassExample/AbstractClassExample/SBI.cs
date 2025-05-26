using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    class SBI:BankAccount
    {
        public override void BankName()
        {
            Console.WriteLine("SBI");
        }

        public override double RateOfInterest()
        {
            return 7.5;
        }
    }
}
