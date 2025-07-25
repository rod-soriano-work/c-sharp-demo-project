using System;
using System.Collections.Generic;

// Base Activity class
abstract class Activity
{
  private DateTime _date;
  private int _minutes;

  public Activity(DateTime date, int minutes)
  {
    _date = date;
    _minutes = minutes;
  }

  public DateTime GetDate() => _date;
  public int GetMinutes() => _minutes;

  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract double GetPace();

  public virtual string GetSummary()
  {
    return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_minutes} min): " +
           $"Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
  }
}
