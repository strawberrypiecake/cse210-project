using System;

public class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time,
                            string street, string city, string state, string country,
                            string weatherForecast)
        : base(title, description, date, time, street, city, state, country)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() +
               $"Type: Outdoor Gathering\n" +
               $"Weather Forecast: {weatherForecast}\n";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Gathering | {base.GetShortDescription().Split('|')[1].Trim()} | {base.GetShortDescription().Split('|')[2].Trim()}";
    }
}