using System;
using System.IO;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(_description);
        Console.Write("How long would you like your session?");
        _duration = int.Parse(Console.ReadLine());
    }
    public void EndMessage()
    {
        Console.WriteLine("Great Job!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
    }
    public void ShowSpinner()
    {
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(_duration);
        while (DateTime.Now < _endTime)
        {
            Console.Write(".");
            Thread.Sleep(1000);

        }
    }
    public void CountDown(int seconds)
    {

    }
}