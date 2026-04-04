using System;

public class ReflectingActivity : Activity
{
  private readonly List<string> _prompts = new List<string>
  {
    "Think of a time when you felt truly happy.",
    "Think of a time when you felt most at peace.",
    "Think of a time you were most proud of yourself.",
    "Think of a time you forgave someone."
  };

  private readonly List<string> _questions = new List<string>
  {
    "In what way was this significant?",
    "Have you ever done anything like this before?",
    "How often do you think about this experience?",
    "How did this experience change you?",
    "What made this experience memorable?",
    "What was the most challenging part of this experience?",
    "What could you advise someone else in a similar situation?",
    "What did you learn about yourself?"
  };

  public override void Run()
  {
    DisplayStartingMessage();

    Random random = new Random();
    string prompt = _prompts[random.Next(_prompts.Count)];

    Console.WriteLine($"Prompt: {prompt}");
    Console.WriteLine();
    ShowSpinner(5);

    Console.WriteLine("Now reflect on the following questions related to this experience:");
    Console.WriteLine();

    int elapsed = 0;
    while (elapsed < _duration)
    {
      string question = _questions[random.Next(_questions.Count)];
      Console.WriteLine($"Question: {question}");
      ShowSpinner(10);
      elapsed += 10;
    }

    DisplayEndingMessage();
  }
}