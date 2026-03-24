using System;

public class Scripture
{
  private Reference _reference;
  private List<Word> _words;

  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    string[] wordArray = text.Split(' ');
    _words = new List<Word>();
    for (int i = 0; i < wordArray.Length; i++)
    {
      _words.Add(new Word(wordArray[i]));
    }
  }

  public void HideRandomWords(int numberToHide)
  {
    Random random = new Random();
    int hiddenCount = 0;
    while (hiddenCount < numberToHide)
    {
      int index = random.Next(_words.Count);
      if (_words[index].IsHidden())
      {
        _words[index].Hide();
        hiddenCount++;
      }
    }
  }
    public string GetDisplayText()
  {
    string displayText = " ";
    for (int i = 0; i < _words.Count; i++)    {
      displayText += _words[i].GetDisplayText() + " ";
    }
    return displayText.Trim();

  }
  public bool IsCompletelyHidden()
  {
    foreach (Word word in _words)
    {
      if (word.IsHidden())
      {
        return false;
      }
    }
    return true;
  }
}