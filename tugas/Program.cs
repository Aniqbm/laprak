using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek Taxi
            Taxi taxi = new Taxi();

            //set nilai properties
            taxi.DriverName = "dito ";
            taxi.OnDuty = true;
            taxi.NumPassanger = 10;

            //pemanggilan method 
            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPasanger();

            Console.ReadKey();
        }
    }
}
