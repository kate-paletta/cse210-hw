using System.Diagnostics.Contracts;

public class Simple : Goal
{
    private bool _isComplete;
    public Simple(string name, string description, int points) : base (name, description, points)
    {
        //set _isComplete here
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
        return "";
    }
}