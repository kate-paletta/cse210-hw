using System;
using System.Collections.Generic;

public class Reference
{
    private string _reference;

    public Reference(string reference)
    {
        _reference = reference;
    }

    public string GetDisplayTxt()
    {
        return _reference;
    }
}
