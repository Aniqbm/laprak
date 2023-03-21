using System;

namespace tugas
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassanger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName); 
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty : Yes");
            }
            else if (OnDuty == false)
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Number of passanger: {0}", NumPassanger);
        }
        public void PickUpPassanger()
        {
            Console.WriteLine("\nDito sedang memjemput penumpang");
        }
        public void DropOffPasanger()
        {
            Console.WriteLine("\nDito sudah mengantar penumpang");
        }
    }
}
