using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager newManager = new();
        //runs the menu loop
        int userChoice = 0;
        while (userChoice != 5)
        {
            newManager.DisplayScore();
            Console.WriteLine(" ");
            Console.WriteLine(newManager.DisplayScore());
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            userChoice = int.Parse(Console.ReadLine());

            // Convert to Switch and Case
            if (userChoice == 1)
            {
                newManager.CreateGoal();
            }
            else if (userChoice == 2)
            {
                newManager.DisplayGoals();
            }
            else if (userChoice ==3)
            {
                newManager.SaveGoals();
            }
            else if (userChoice == 4)
            {
                newManager.LoadGoals();
            }
            else if (userChoice ==5)
            {
                newManager.RecordEvent();
            }
            else if (userChoice == 6)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
            }

        }
    }
}