using System;
using System.Collections.Generic;
public class Entry
{ 
    public string _date;
    
    //getting the prompt and assigning it to _promptTxt
    public string _promptTxt;
    public void AssignPromptTxt()
    {
        PromptGen prompt = new PromptGen();
        _promptTxt = prompt.GetRandomPrompt();
    }
    public string _entryTxt;

    public void Display()
    {
        Console.WriteLine($"Date: (date) - Prompt: {_promptTxt}\n(entryTXT)");
    }
}