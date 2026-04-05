using System;

public class Reception : Event
{
    public string rsvpEmail;

    public Reception(string title, string description, string date, string time,
                     string street, string city, string state, string country,
                     string rsvpEmail)
        : base(title, description, date, time, street, city, state, country)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() +
               $"Type: Reception\n" +
               $"RSVP Email: {rsvpEmail}\n";
    }

    public override string GetShortDescription()
    {
        return $"Reception | {title} | {date}";
    }
}
