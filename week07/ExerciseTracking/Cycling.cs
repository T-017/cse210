class Cycling : Activity
{
  private double _speedKph; // stored speed in km/h

  public Cycling(string date, int length, double speedKph) : base(date, length)
  {
    _speedKph = speedKph;
  }

  public override double GetDistance() => _speedKph * GetLength() / 60.0;

  public override double GetSpeed() => _speedKph;

  public override double GetPace()
  {
    double spd = GetSpeed();
    return spd == 0 ? 0 : 60.0 / spd;
  }
}