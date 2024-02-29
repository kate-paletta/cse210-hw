using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int gradePerc = int.Parse(userInput);

        if (gradePerc >= 90)
        {
            Console.WriteLine("You got an A");
        }
        else if (gradePerc >= 80)
        {
            Console.WriteLine("You got a B");
        }
        else if (gradePerc >= 70)
        {
            Console.WriteLine("You got a C");
        }
        else if (gradePerc >= 60)
        {
            Console.WriteLine("You got a D");
        }
        else
        {
            Console.WriteLine("You got an F");
        }

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