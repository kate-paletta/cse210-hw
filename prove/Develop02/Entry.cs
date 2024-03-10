using System;
using System.Collections.Generic;
public class Entry
{ 
    //displaying the menu and getting the user choice
    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");   
    }
    public int _choice;
    public int GetUserChoice()
    {
        Console.Write("Enter your choice: ");
        _choice = int.Parse(Console.ReadLine());
        return _choice;
    }
    
    //getting the prompt for option 1 the taking in the user input
    public string _prompt;
    public string _userEntry;
    public void GetPromptAndEntry()
    {
        PromptGen prompt = new PromptGen();
        _prompt = prompt.GetRandomPrompt();
        Console.WriteLine(_prompt);
        _userEntry = Console.ReadLine();
    }
    //getting the date
    public string _dateTxt;
    public void GetDate()
    {
        _dateTxt = DateTime.Now.ToShortDateString();
    }
    
    //Organizing the entry
    public string _completeEntry;
    public string CompleteEntry()
    {
        GetDate();
        _completeEntry = $"Date: {_dateTxt} - Prompt: {_prompt}\n{_userEntry}";
        return _completeEntry;
    }


}