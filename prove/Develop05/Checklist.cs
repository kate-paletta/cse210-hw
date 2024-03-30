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
        return "";
    }
}