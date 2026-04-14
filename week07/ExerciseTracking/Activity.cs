using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance(); // km
    public abstract double GetSpeed();    // kph
    public abstract double GetPace();     // min per km

    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min): Distance {GetDistance():0.00} km, Speed {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min per km";
    }
}