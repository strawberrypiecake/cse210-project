using System;

public class Event
{
    // Private member variables
    private string title;
    private string description;
    private string date;
    private string time;
    private string street;
    private string city;
    private string state;
    private string country;

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

    // Returns the standard details of the event
    public string GetStandardDetails()
    {
        return $"Title: {title}\n" +
               $"Description: {description}\n" +
               $"Date: {date}\n" +
               $"Time: {time}\n" +
               $"Address: {GetFullAddress()}\n";
    }

    // Virtual method to get full details, can be overridden
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    // Virtual method to get short description, can be overridden
    public virtual string GetShortDescription()
    {
        return $"Event | {title} | {date}";
    }

    // Helper method to format the full address
    protected string GetFullAddress()
    {
        return $"{street}, {city}, {state}, {country}";
    }
}