using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Entry entry = new Entry();
        

        while (true)
        {
            entry.DisplayMenu();
            int _choice = entry.GetUserChoice();
            if (_choice == 1)
            {
                entry.GetPromptAndEntry();
                journal.AddEntry(entry.CompleteEntry());
            }
            else if (_choice == 2)
            {
                journal.DisplayAll();
            }
            else if (_choice == 3)
            {
                //load method
                Console.WriteLine("Please type the name of the file to load from: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (_choice == 4)
            {
                //save method
                Console.WriteLine("Please type the name of the file to save to: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (_choice >= 6)
            {
                //EXTRA: this is so the program doesn't stop running if a user puts in a number that is over 5
                Console.WriteLine("Please enter a valid option.");
            }
            else
            {
                break;
            }
        }   
    }
   
}