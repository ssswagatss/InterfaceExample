using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class ElectricityCharger: ICharger
    {
        public bool StartCharge()
        {
            Console.WriteLine("Charge Started by Electricity");
            return true;
        }

        public bool EndCharge()
        {
            Console.WriteLine("Charge End by Electricity");
            return true;
        }
    }
}
