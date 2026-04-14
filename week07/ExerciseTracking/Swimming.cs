class Swimming : Activity
{
  private int _laps;

  public Swimming(string date, int length, int laps) : base(date, length)
  {
    _laps = laps;
  }

  public override double GetDistance()
  {
    return _laps * 50.0 / 1000.0;
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