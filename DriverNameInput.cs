using System;
using System.Globalization; 

namespace DriverName
{
    class Taxi
    {
       

        public int NumPassenger;

        public string DriverName;

        public string OnDuty;
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(1, 100);
        }

        
        public void TaxiInfo()
        {
            System.Console.WriteLine("Masukkan Nama Driver!");
            DriverName = Console.ReadLine();
            System.Console.WriteLine("Apakah Anda Sedang On Duty? Ya/Tidak");
            OnDuty = Console.ReadLine();
            if (OnDuty == "ya")
            {
                System.Console.WriteLine("On Duty: Yes");
            }
            else if (OnDuty == "Ya")
            {
                System.Console.WriteLine("On Duty: Yes");
            }
            else
            {
                System.Console.WriteLine("On Duty: No");
            }
            Taxi random = new Taxi();
            Console.Clear();

            System.Console.WriteLine("Drive Name: " + DriverName);
            System.Console.WriteLine("OnDuty: "+OnDuty);
            System.Console.WriteLine("Number of Passenger: " + RandomNumber(1000, 9999));
        }

        public void PickUpPassenger()
        {
            System.Console.WriteLine(DriverName + " sedang menjemput penumpang");
        }

        public void DropOffPassanger()
        {
            System.Console.WriteLine(DriverName + " selesai mengantar penumpang");
        }

        public static void Main(string[] arg)
        {
            Taxi taxi = new Taxi();
            taxi.TaxiInfo();
            System.Console.WriteLine("");
            taxi.PickUpPassenger();
            taxi.DropOffPassanger();
        }
    }
}
