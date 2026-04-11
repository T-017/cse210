using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
  private List<Goal> _goals = new List<Goal>();
  private int _score = 0;

  public GoalManager() { }

  public void Start()
  {
    Console.WriteLine("Welcome to your personal quest.");

    bool running = true;
    while (running)
    {
      DisplayUserInfo();

      Console.WriteLine("Menu Options:");
      Console.WriteLine();
      Console.WriteLine("  1. Create New Goal");
      Console.WriteLine("  2. List Goals");
      Console.WriteLine("  3. Save Goals");
      Console.WriteLine("  4. Load Goals");
      Console.WriteLine("  5. Record Event");
      Console.WriteLine("  6. Quit");

      Console.Write("Select a choice from the menu: ");
      string choice = Console.ReadLine()?.Trim();

      switch (choice)
      {
        case "1":
          CreateGoal(); break;
        case "2":
          ListGoals(); break;
        case "3":
          SaveGoals(); break;
        case "4":
          LoadGoals(); break;
        case "5":
          RecordEvent(); break;
        case "6":
          running = false;
          Console.WriteLine("Thank you for visiting.");
          break;
        default:
          Console.WriteLine("Invalid choice, please try again.");
          break;
      }
    }
  }

  public void DisplayUserInfo()
  {
    int level = 1 + (_score / 1000);
    Console.WriteLine($"Level: {level}");
    Console.WriteLine($"Experience: {_score}");
    Console.WriteLine(new string('-', 50));
  }

  public void ListGoals()
  {
    if (_goals.Count == 0)
    {
      Console.WriteLine("No goals available."); return;
    }
    Console.WriteLine("Goal Details:");
    for (int i = 0; i < _goals.Count; i++)
    {
      Goal goal = _goals[i];
      Console.WriteLine($"{i + 1}. {goal.GetDetailsString()}");
    }
  }

  public void CreateGoal()
  {
    Console.WriteLine("Select New Goal Type:");
    Console.WriteLine("  1. Simple Goal");
    Console.WriteLine("  2. Eternal Goal");
    Console.WriteLine("  3. Checklist Goal");
    Console.Write("Enter choice: ");
    string choice = Console.ReadLine()?.Trim();

    Console.Write("What is the title of your goal? ");
    string name = Console.ReadLine()?.Trim() ?? "Untitled Goal";

    Console.Write("What is a short description of it? ");
    string description = Console.ReadLine()?.Trim() ?? "No description";

    Console.Write("How many points with this goal be worth? ");
    int points = int.TryParse(Console.ReadLine(), out int p) ? p : 50;

    switch (choice)
    {
      case "1":
        _goals.Add(new SimpleGoal(name, description, points));
        Console.WriteLine("Simple goal documented.");
        break;

      case "2":
        _goals.Add(new EternalGoal(name, description, points));
        Console.WriteLine("Eternal goal documented.");
        break;

      case "3":
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int target = int.TryParse(Console.ReadLine(), out int t) ? t : 5;

        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.TryParse(Console.ReadLine(), out int b) ? b : 100;

        _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        Console.WriteLine("Checklist goal documented.");
        break;

      default:
        Console.WriteLine("Invalid goal type, goal not created."); break;
    }
  }

  public void RecordEvent()
  {
    if (_goals.Count == 0)
    {
      Console.WriteLine("No goals available to record an event for."); return;
    }

    ListGoals();

    Console.Write("Select a goal to record an event for: ");
    if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= _goals.Count)
    {
      Goal goal = _goals[index - 1];
      int pointsEarned = goal.RecordEvent();

      if (pointsEarned > 0)
      {
        _score += pointsEarned;
        Console.WriteLine($"\n You earned {pointsEarned} points.");

        if (goal.IsComplete() && goal is SimpleGoal) Console.WriteLine("You have completed a simple goal.");
        else if (goal is ChecklistGoal cg && cg.IsComplete()) Console.WriteLine("You have completed a checklist goal with bonus.");
      }
      else
      {
        Console.WriteLine("You have already completed this goal.");
      }
    }
    else
    {
      Console.WriteLine("Invalid selection.");
    }
  }

  public void SaveGoals()
  {
    try
    {
      using (StreamWriter writer = new StreamWriter("goals.txt"))
      {
        writer.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
          writer.WriteLine(goal.GetStringRep());
        }
      }
      Console.WriteLine("Goals saved successfully.");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error saving goals: {ex.Message}");
    }
  }

  public void LoadGoals()
  {
    if (!File.Exists("goals.txt"))
    {
      Console.WriteLine("No saved goals found."); return;
    }
    try
    {
      string[] lines = File.ReadAllLines("goals.txt");
      if (lines.Length == 0) return;

      _score = int.Parse(lines[0]);
      _goals.Clear();

      for (int i = 1; i < lines.Length; i++)
      {
        string line = lines[i];
        string[] parts = line.Split('|');

        if (parts.Length < 2) continue;
        string type = parts[0];

        if (type == "SimpleGoal'")
        {
          _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
        }
        else if (type == "EternalGoal")
        {
          _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
        }
        else if (type == "ChecklistGoal")
        {
          _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6])));
        }
      }
      Console.WriteLine("Goals loaded successfully.");
    }

    catch (Exception ex)
    {
      Console.WriteLine($"Error loading goals: {ex.Message}");
    }
  }
}