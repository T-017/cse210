using System;

public class BreathingActivity : Activity
{
  public BreathingActivity()
  {
    _name = "Breathing Activity";
    _description = "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.";
  }

  public override void Run()
  {
    DisplayStartingMessage();
    int elapsed = 0;
    bool breatheIn = true;

    while (elapsed < _duration)
    {
      if (breatheIn)
      {
        Console.Write("Breathe in... ");
        ShowCountdown(4);
        elapsed += 4;
      }
      else
      {
        Console.Write("Breathe out... ");
        ShowCountdown(6);
        elapsed += 6;
      }

      breatheIn = !breatheIn;
      if (elapsed > _duration)
      {
        break;
      }
    }

    DisplayEndingMessage();
  }
}
