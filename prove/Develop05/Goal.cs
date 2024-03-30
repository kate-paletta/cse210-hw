public abstract class Goal
{
    //VARIABLES
    protected string _shortName;
    protected string _description;
    protected int _points;

    //CONSTRUCTOR
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //METHODS
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public string GetDetailsString()
    {
        return "";
        //this should read through the list and format it to display
    }
    public abstract string GetGoalDetails();
}