using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
  protected string _name;
  protected string _description;
  protected int _duration;

  protected void DisplayStartingMessage()
  {
    Console.Clear();
    Console.WriteLine($"--- {_name} ---");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();
    Console.Write("How long, in seconds, would you like to do this activity? ");

    while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
    {
      Console.Write("Please enter a valid positive integer for the duration: ");
    }

    Console.WriteLine();
    Console.WriteLine("Get ready...");
    ShowSpinner(5);
  }

  protected void DisplayEndingMessage()
  {
    Console.WriteLine();
    Console.WriteLine("Well done.");
    ShowSpinner(3);
    Console.WriteLine();
    Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
    ShowSpinner(5);
  }

  protected void ShowSpinner(int seconds)
  {
    List<string> spinner = new List<string> { "|", "/", "-", "\\" };
    int index = 0;
    DateTime endTime = DateTime.Now.AddSeconds(seconds);

    while (DateTime.Now < endTime)
    {
      Console.Write(spinner[index]);
      Thread.Sleep(250);
      Console.Write("\b");
      index = (index + 1) % spinner.Count;
    }
    Console.Write(" ");
    Console.WriteLine();
  }

  protected void ShowCountdown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write($"{i} ");
      Thread.Sleep(1000);
    }
    Console.WriteLine();
  }

  public abstract void Run();
}