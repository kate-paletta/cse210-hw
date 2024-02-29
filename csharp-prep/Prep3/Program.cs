using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number?");
        // string answer = Console.ReadLine();
        // int magicNum = int.Parse(answer);
        Random randomNum = new Random();
        int magicNum = randomNum.Next(1, 101);

        int guess = -1;

        while (guess != magicNum)
        {
            Console.WriteLine("What is your guess?");
            string answer2 = Console.ReadLine();
            guess = int.Parse(answer2);

            if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
        
    }
}