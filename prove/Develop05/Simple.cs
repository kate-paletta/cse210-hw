using System.Diagnostics.Contracts;

public class Simple : Goal
{
    private bool _isComplete;
    public Simple(string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }

    public Simple(string name, string description, int points, bool isComplete) : base (name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        // _isComplete -> TRUE
        // PUT Message
        // RETURN _points
    }
    public override bool IsComplete()
    {
        //return true if goal is completed
        //determine if a goal is complete depending on the goal type
        return _isComplete;
    }
    public override string GetSaveString()
    {
        //provide all details of goal in a way to save and load
        
        return base.GetSaveString() + $"|{_isComplete}";
    }
}