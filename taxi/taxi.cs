using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    public class Taxi
    {
        //properties
        public string Drivername { get; set; }
        public bool Onduty { get; set; }
        public int NumPassenger { get; set; }
        
        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Drivername : {0}", Drivername);
            Console.WriteLine("Onduty : {0}", Onduty);
            Console.WriteLine("NumPassenger : {0}\n", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang",Drivername);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang",Drivername);
        }
    }
}
