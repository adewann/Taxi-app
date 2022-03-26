using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Taxi
{
    class program
    {
        ststic void Main(string[] args)
        {
            //membuat object taxi
            Taxi taxi = new Taxi();

            //Pengesahan nilai properties
            taxi.DriverName = "jonoo";
            taxi.OnDuty = true;
            taxi.NumPassenger = 19;

            //pengambilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
