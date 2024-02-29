using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int gradePerc = int.Parse(userInput);
        string letter = " ";

        if (gradePerc >= 90)
        {
            letter = "A";
        }
        else if (gradePerc >= 80)
        {
            letter = "B";
        }
        else if (gradePerc >= 70)
        {
            letter = "C";
        }
        else if (gradePerc >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");

        if (gradePerc >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass, but keep working hard!");
        }
    }
}