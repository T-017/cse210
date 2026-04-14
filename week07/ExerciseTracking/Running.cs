class Running : Activity
{
  private double _distance; // stored in km

  public Running(string date, int length, double distance) : base(date, length)
  {
    _distance = distance;
  }

  public override double GetDistance()
  {
    return _distance;
  }

  public override double GetSpeed()
  {
    int len = GetLength();
    return len == 0 ? 0 : (GetDistance() / len) * 60;
  }

  public override double GetPace()
  {
    double dist = GetDistance();
    return dist == 0 ? 0 : GetLength() / dist;
  }
}