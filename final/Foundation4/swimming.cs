using System;

class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0 * 0.62; // miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthMinutes) * 60;
    }
}