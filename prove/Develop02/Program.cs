using System;
using System.Collections.Generic;
class Program
{

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Menu menu = new Menu();
        menu.UserChoices(journal);

        
    }
}