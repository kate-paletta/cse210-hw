using System;

class Program
{
    static void Main(string[] args)
    {
        
        Breathe breathe1 = new("Breathing", "Descript", 10);

        // Activity activity1 = new();
        breathe1.StartMessage();
        breathe1.ShowSpinner();
        breathe1.EndMessage();
    }
}