using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                journal.AddEntry();
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                //load method
                Console.WriteLine("Please type the name of the file to load from: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (choice == 4)
            {
                //save method
                Console.WriteLine("Please type the name of the file to save to: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (choice == 5)
            {
                break;
            }
            else
            {
                //EXTRA: this is so the program doesn't stop running if a user puts in a number that is over 5
                Console.WriteLine("Please enter a valid option.");
            }
        }
    }

}