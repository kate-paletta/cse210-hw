using System;
using System.Collections.Generic;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayTxt()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}