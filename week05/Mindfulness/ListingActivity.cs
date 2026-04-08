using System;

public class ListingActivity : Activity
{
  private readonly List<string> _prompts = new List<string>
  {
    "List as many things as you can that you are grateful for.",
    "List as many people as you can who have had a positive impact on your life.",
    "List as many personal strengths as you can.",
    "List as many happy memories as you can."
  };

  public ListingActivity()
  {
    _name = "Listing Activity";
    _description = "This activity will help you reflect on things in your life by having you list as many items as you can.";
  }

  public override void Run()
  {
    DisplayStartingMessage();

    Random random = new Random();
    string prompt = _prompts[random.Next(_prompts.Count)];

    Console.WriteLine($"List as many items as you can in the following category:");
    Console.WriteLine();
    Console.WriteLine($"--- {prompt} ---");
    Console.WriteLine();

    Console.WriteLine("You may begin in:");
    ShowCountdown(5);

    Console.WriteLine("Start listing the items now. Press Enter after each item.");
    Console.WriteLine("When time is up, the program will continue automatically.");
    Console.WriteLine();

    int itemCount = 0;
    DateTime endTime = DateTime.Now.AddSeconds(_duration);

    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      string input = Console.ReadLine()?.Trim();
      if (!string.IsNullOrEmpty(input))
      {
        itemCount++;
      }

      if (DateTime.Now >= endTime)
      {
        break;
      }

      Console.WriteLine();
      Console.WriteLine($"You listed {itemCount} items.");
    }

    DisplayEndingMessage();
  }
}
