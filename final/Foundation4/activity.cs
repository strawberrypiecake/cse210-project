using System;

abstract class Activity
{
    private DateTime date;
    private int lengthMinutes;

    public DateTime Date => date;
    public int LengthMinutes => lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        this.date = date;
        this.lengthMinutes = lengthMinutes;
    }

    public abstract double GetDistance(); // miles
    public abstract double GetSpeed();    // mph

    public virtual double GetPace()
    {
        double distance = GetDistance();
        return distance > 0 ? LengthMinutes / distance : 0;
    }

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({LengthMinutes} min) - " +
               $"Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.00} min per mile";
    }
}