using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Proverb 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths.");
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayTxt());
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            else
                scripture.HideRandomWords(3); // Hide 3 random words each time
        }
    }
}