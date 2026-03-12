public class PromptGen
{
  List<string> _prompts = new List<string>()
  {
    "What was the best part of your day?",
    "What was the worst part of your day?",
    "What are you grateful for today?",
    "What is something you learned today?",
    "What is a goal you have for tomorrow?",
    "What is a challenge you faced today?",
    "What is something that made you happy today?",
  };

  Random random = new Random();

  public string GetRandomPrompt()
  {
    int index = random.Next(_prompts.Count);
    return _prompts[index];
  }

  public void AddUserPrompt(string userPrompt)
  {
    _prompts.Add(userPrompt);
  }
}