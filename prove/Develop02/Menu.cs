using System;
using System.Collections.Generic;

public class Menu 
{
    public int _choice;
    public string _prompt;
    public string _userEntry;
 
    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        string _userChoice = Console.ReadLine();
        _choice = int.Parse(_userChoice);   
    }

    //getting the prompt and assigning it to _promptTxt
    public void GetPromptAndEntry()
    {
        PromptGen prompt = new PromptGen();
        _prompt = prompt.GetRandomPrompt();
        Console.WriteLine(_prompt);
        _userEntry = Console.ReadLine();
    }

    public void UserChoices(Journal journal)
    {
        do
        {
            DisplayMenu();
            if (_choice ==1)
            {
                GetPromptAndEntry();
            }
            else if (_choice == 2)
            {
                journal.DisplayAll();
            }
            DisplayMenu();
        } while (_choice != 5);
        
    }
}