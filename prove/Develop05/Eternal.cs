public class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base (name, description, points)
    {
        
        _shortName = name;
        _description = description;
        _points = points;
    }
    public override void RecordEvent()
    {
        //mark complete
        //add points
    }
    public override bool IsComplete()
    {
        //return true if goal is completed
        //determine if a goal is complete depending on the goal type
        return true;
    }
    public override string GetGoalDetails()
    {
        //provide all details of goal in a way to save and load
        Console.Write("What is the name of your goal?");
        _shortName = Console.ReadLine();
        Console.Write("Please describe your goal: ");
        _description = Console.ReadLine();
        Console.Write("How many points will you earn when completed?");
        _points = int.Parse(Console.ReadLine());
        return $"EternalGoal:{_shortName} | {_description} | {_points}";
    }
}