using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNum = PromptUserNumber();
        int square = SquareNumber(favNum);
        DisplayResult(userName, square);
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please eneter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favNum = int.Parse(Console.ReadLine());
            return favNum;
        }

        static int SquareNumber(int favNum)
        {
            int square = favNum * favNum;
            return square;
        }

        static void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}");
        }
}