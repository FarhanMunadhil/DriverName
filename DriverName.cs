using System;
public class Taxi
{

    string DriverName;
    bool OnDuty;

    public int NumPassenger;

    public void TaxiInfo()
    {
        DriverName = "Farhan 2706";
        OnDuty = true;
        NumPassenger = 10;
        System.Console.WriteLine("Driver Name: " + DriverName);
        if (OnDuty = true)
        {
            System.Console.WriteLine("On Duty: Yes");
        }
        else
        {
            System.Console.WriteLine("On Duty: No");
        }
        System.Console.WriteLine("Number of Passenger: " + NumPassenger);
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
        Console.ReadKey();
    }
}
