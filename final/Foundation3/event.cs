using System;

public class Event
{
    // Public variables (no private fields)
    public string title;
    public string description;
    public string date;
    public string time;
    public string street;
    public string city;
    public string state;
    public string country;

    // Constructor
    public Event(string title, string description, string date, string time,
                 string street, string city, string state, string country)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public string GetStandardDetails()
    {
        return $"Title: {title}\n" +
               $"Description: {description}\n" +
               $"Date: {date}\n" +
               $"Time: {time}\n" +
               $"Address: {street}, {city}, {state}, {country}\n";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Event | {title} | {date}";
    }
}
