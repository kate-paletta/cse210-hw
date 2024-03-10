using System;
using System.Collections.Generic;

public class Menu 
{
    public int _choice;
 
    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");   
    }

    public int GetUserChoice()
    {
        _choice = int.Parse(Console.ReadLine());
        return _choice;
    }

}