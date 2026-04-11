using System;
using System.Collections.Generic;

abstract class Goal
{
  protected string _shortName;
  protected string _description;
  protected int _points;

  public Goal(string shortName, string description, int points)
  {
    _shortName = shortName;
    _description = description;
    _points = points;
  }

  public abstract void RecordEvent();
  public abstract bool IsComplete();
  
  public string GetDetailsString()
  {
    return $"{(IsComplete() ? "[X]" : "[ ]")} {_shortName} ({_points} points) - {_description}";
  }
  
  public abstract string GetStringRep();

  public string GetShortName()
  {
    return _shortName;
  }
}