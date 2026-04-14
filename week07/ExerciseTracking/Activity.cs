using System;
using System.Collections.Generic;

abstract class Activity
{
  private string _date;
  private int _length;

  public Activity(string date, int length)
  {
    _date = date;
    _length = length;
  }

  protected int GetLength() => _length;

  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract double GetPace();

  public string GetSummary()
  {
    string activityType = GetType().Name;
    double distance = GetDistance();
    double speed = GetSpeed();
    double pace = GetPace();

    return $"{_date} {activityType} ({_length} min): " +
           $"Distance {distance:F1} km, " +
           $"Speed: {speed:F1} kph, " +
           $"Pace: {pace:F2} min per km";
  }
}