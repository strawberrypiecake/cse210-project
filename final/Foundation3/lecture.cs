using System;

public class Lecture : Event
{
    public string speakerName;
    public int capacity;

    public Lecture(string title, string description, string date, string time,
                   string street, string city, string state, string country,
                   string speakerName, int capacity)
        : base(title, description, date, time, street, city, state, country)
    {
        this.speakerName = speakerName;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() +
               $"Type: Lecture\n" +
               $"Speaker: {speakerName}\n" +
               $"Capacity: {capacity}\n";
    }

    public override string GetShortDescription()
    {
        return $"Lecture | {title} | {date}";
    }
}
