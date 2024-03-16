using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        SplitWords(text);
    }

    private void SplitWords(string text)
    {
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(0, _words.Count);
        }
    }

    public string GetDisplayTxt()
    {
        string displayText = _reference.GetDisplayTxt() + ": ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayTxt() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}