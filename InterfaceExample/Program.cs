using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var bCharger = new BatteryCharger();
            //bCharger.StartCharge();
            //bCharger.EndCharge();

            StartCharging(bCharger);
            EndCharging(bCharger);

            var eCharger = new ElectricityCharger();
            //eCharger.StartCharge();
            //eCharger.EndCharge();
            StartCharging(eCharger);
            EndCharging(eCharger);


            Console.ReadKey();
        }

        //If I ask for ICharger -> Give me Battery Charger
        public static void StartCharging(ICharger charger)
        {
            //Log some information about charging
            charger.StartCharge();
        }

        public static void EndCharging(ICharger charger)
        {
            //Log some information about charging
            charger.EndCharge();
        }
    }
}
