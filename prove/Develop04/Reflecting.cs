using System;
using System.IO;

public class Reflecting : Activity
{
    private List<string> _prompts = new();
    private List<string> _questions = new();
    public Reflecting(string name, string description, int duration) : base(name, description, duration)
    {

    }
    public void Run()
    {

    }
    public string GetRandomPrompt()
    {
        return "";
    }
    public string GetRandomWQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestion()
    {
        
    }
}
