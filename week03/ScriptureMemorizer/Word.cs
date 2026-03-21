using System;

public class Word
{
  private string _text;
  private bool _isHidden;

  public Word(string text)
  {
    _text = text;
    _isHidden = false;
  }

  public void Hide()
  {
    for (int i = 0; i < _text.Length; i++)
    {
      _text = _text.Replace(_text[i], '_');
    }
    _isHidden = true;
  }

  public void Show()
  {
    _isHidden = false;
  }

  public bool IsHidden()
  {
    if (_isHidden)
    {
      return false;
    }
    else
    {
      return true;
    }
  }

  public string GetDisplayText()
  {
    return _text;
  }
}