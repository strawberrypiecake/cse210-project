using System;

class Program
{
    static void Main()
    {
        // Create events
        Lecture lecture = new Lecture(
            "Introduction to AI",
            "An insightful lecture about the basics of artificial intelligence.",
            "2025-09-10",
            "18:00",
            "123 Tech Lane",
            "San Francisco",
            "CA",
            "USA",
            "Dr. Jane Smith",
            100
        );

        Reception reception = new Reception(
            "Annual Gala",
            "A reception to celebrate our yearly achievements.",
            "2025-10-01",
            "20:00",
            "789 Celebration Ave",
            "New York",
            "NY",
            "USA",
            "rsvp@company.com"
        );

        OutdoorGathering outdoor = new OutdoorGathering(
            "Summer Beach Party",
            "Fun gathering with music, food, and games by the beach.",
            "2025-07-15",
            "15:00",
            "456 Ocean Drive",
            "Miami",
            "FL",
            "USA",
            "Sunny with light breeze"
        );

        // Array of events
        Event[] events = { lecture, reception, outdoor };

        // Display marketing messages for each event
        foreach (Event ev in events)
        {
            Console.WriteLine("----- Standard Details -----");
            Console.WriteLine(ev.GetStandardDetails());

            Console.WriteLine("----- Full Details -----");
            Console.WriteLine(ev.GetFullDetails());

            Console.WriteLine("----- Short Description -----");
            Console.WriteLine(ev.GetShortDescription());

            Console.WriteLine();
        }
    }
}