using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    class ICICI:BankAccount
    {
        public override void BankName()
        {
            Console.WriteLine("ICICI");
        }

        public override double RateOfInterest()
        {
            return 8.0;
        }
    }
}
