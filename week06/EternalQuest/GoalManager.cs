using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
  private List<GoalManager> _goals;
  private int _score;

  public GoalManager()
  {
    _goals = new List<GoalManager>();
    _score = 0;
  }

  public void Start()
  {
    Console.WriteLine("Welcome to your personal quest.");
    Console.WriteLine("Please select one of the options:");
    Console.WriteLine("1. New goal");
    Console.WriteLine("2. List of goals");
    Console.WriteLine("3. Save goals");
    Console.WriteLine("4. Load goals");
    Console.WriteLine("5. Exit");

    string choice = Console.ReadLine();

    switch (choice)
    {
      case "1":
        CreateGoal();
        break;
      case "2":
        ListGoals();
        break;
      case "3":
        SaveGoals();
        break;
      case "4":
        LoadGoals();
        break;
      case "5":
        Console.WriteLine("Thank you for playing the Eternal Quest!");
        break;
      default:
        Console.WriteLine("Invalid choice. Please try again.");
        Start();
        break;
    }
  }

  public void DisplayInfo()
  {
    Console.WriteLine($"You currently have {_score} points.");
  }

  public void ListGoalNames()
  {
    Console.WriteLine("Here are your current goals:");
    foreach (var goal in _goals)
    {
      Console.WriteLine(goal);
    }
  }

  public void ListGoalDetails()
  {

  }

  public void CreateGoal()
  {
    Console.WriteLine("What type of goal would you like to create?");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");

    string choice = Console.ReadLine();

    switch (choice)
    {
      case "1":
        CreateSimpleGoal();
        break;
      case "2":
        CreateEternalGoal();
        break;
      case "3":
        CreateChecklistGoal();
        break;
      default:
        Console.WriteLine("Invalid choice. Please try again.");
        CreateGoal();
        break;
    }
  }

  public void RecordEvent()
  {

  }

  public void SaveGoals()
  {
    Console.WriteLine("Please enter the filename to save your goals:");
    string filename = Console.ReadLine();

    using (StreamWriter writer = new StreamWriter(filename))
    {
      foreach (var goal in _goals)
      {
        writer.WriteLine(goal);
      }
    }

    Console.WriteLine("Goals saved successfully.");
  }

  public void LoadGoals()
  {
    Console.WriteLine("Please enter the filename to load your goals:");
    string filename = Console.ReadLine();

    if (File.Exists(filename))
    {
      using (StreamReader reader = new StreamReader(filename))
      {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
          // Assuming each line represents a goal, you would need to parse it and create a Goal object
          // For example: Goal goal = ParseGoal(line);
          // _goals.Add(goal);
        }
      }

      Console.WriteLine("Goals loaded successfully.");
    }
    else
    {
      Console.WriteLine("File not found. Please try again.");
    }
  }
}