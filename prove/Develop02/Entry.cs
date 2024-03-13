using System;
using System.Collections.Generic;
public class Entry
{ 
    public string _prompt;
    public string _userEntry;
    public string _dateTxt;
    
    public string DisplayEntry()
    {
        return $"Date: {_dateTxt} - Prompt: {_prompt}\n{_userEntry}";
    }
}