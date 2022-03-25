using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taxi
            Taxi taxi1 = new Taxi();

            //pengesetan nilai properties
            taxi1.Drivername = "sidiq";
            taxi1.Onduty = true;
            taxi1.NumPassenger = 4484;

            //pemanggilan method
            taxi1.TaxiInfo();
            taxi1.PickUpPassenger();
            taxi1.DropOffPassenger();
            Console.ReadKey();
        }
    }
}
