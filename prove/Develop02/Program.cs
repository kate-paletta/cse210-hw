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
            int choice = entry.GetUserChoice();
            if (choice == 1)
            {
                entry.GetPromptAndEntry();
                journal.AddEntry(entry.CompleteEntry());
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                //load method
            }
            else if (choice == 4)
            {
                //save method
            }
            else
            {
                break;
            }
        }   
    }
   
}