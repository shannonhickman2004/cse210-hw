using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("13856 S Carnoustie", "Herriman", "UT", "84096");
        Address address2 = new Address("45 Hedgehog", "Sandy", "UT", "84321");
        Address address3 = new Address("45 Buckeye View", "Riverton", "UT", "84065");

        Lecture lecture = new Lecture("Python Programming", "Python, Beginning Basics", "2024-06-15", "10:00 AM", address1, "Karina Guymon", 100);
        Reception reception = new Reception("Networking Event", "A chance to network with professionals.", "2024-07-06", "7:00 PM", address2, "shannonhickman.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Networking Picnic", "A delicious outdoor picnic with networking.", "2024-08-06", "12:00 PM", address3, "Cloudy");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
