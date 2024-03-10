using System;
using System.Collections.Generic;
public class Entry
{ 
    //getting the date
    public string _dateTxt;
    public void GetDate()
    {
        _dateTxt = DateTime.Now.ToShortDateString();
    }
    
    //Getting the prompt & entry from Menu
    public string _entryTxt;
    public string _promptTxt;
    public string _completeEntry;
    
    public string CompleteEntry()
    {
        GetDate();
        Menu menu = new Menu();
        _entryTxt = menu._userEntry;
        _promptTxt = menu._prompt;
        _completeEntry = $"Date: {_dateTxt} - Prompt: {_promptTxt}\n{_entryTxt}";
        return _completeEntry;
    }

}