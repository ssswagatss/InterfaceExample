using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class BatteryCharger: ICharger//, ITest
    {
        public bool StartCharge()
        {
            Console.WriteLine("Charge Started by Battery");
            return true;
        }

        public bool EndCharge()
        {
            Console.WriteLine("Charge End by Battery");
            return true;
        }
    }
}
