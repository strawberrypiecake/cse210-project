using System;

class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(DateTime date, int lengthMinutes, double speed)
        : base(date, lengthMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return speed * LengthMinutes / 60;
    }

    public override double GetSpeed()
    {
        return speed;
    }
}