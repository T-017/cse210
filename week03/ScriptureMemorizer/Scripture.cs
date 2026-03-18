using System;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
  private string _reference;
  private List<Word> _words;

  public Scripture(string Reference, List<Word> Words)
  {
    _reference = Reference;
    _words = Words;
  }

  public void HideRandomWords(int numberToHide)
  {
    public string GetDisplayText(string text)
    {
      string[] words = text.Split(' ');
      for (int i = 0; i < numberToHide; i++)
      {
        int randomIndex = new Random().Next(words.Length);
        words[randomIndex] = "____";
      }
      return string.Join(" ", words);
    }
  }

  public bool IsCompletelyHidden()
  {
    return !_words.Contains("____");
  }
}