public class Checklist : Goal
{
    private int _amntCompleted;
    private int _baseAmnt;
    private int _bonus;
    
    public Checklist(string name, string description, int points) : base (name, description, points)
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
        Console.Write("How many times will you do this goal for it to be complete?");
        _baseAmnt = int.Parse(Console.ReadLine());
        Console.Write("How many points will you earn for each time you record your progress?");
        _points = int.Parse(Console.ReadLine());
        Console.Write("When you've completed all of your tasks how many points would like to earn?");
        _bonus = int.Parse(Console.ReadLine());
        return $"ChecklistGoal:{_shortName} | {_description} | {_points} | {_bonus} | {_baseAmnt} | {_amntCompleted}";
    }
}