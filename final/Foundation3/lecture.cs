using System;

public class Lecture : Event
{
    private string speakerName;
    private int capacity;

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
        return base.GetStandardDetails() +
               $"Type: Lecture\n" +
               $"Speaker: {speakerName}\n" +
               $"Capacity: {capacity}\n";
    }

    public override string GetShortDescription()
    {
        return $"Lecture | {base.GetShortDescription().Split('|')[1].Trim()} | {base.GetShortDescription().Split('|')[2].Trim()}";
    }
}