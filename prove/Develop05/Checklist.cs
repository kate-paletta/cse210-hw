public class Checklist : Goal
{
    private bool _isComplete;
    private int _amntCompleted;
    private int _baseAmnt;
    private int _bonus;
    
    public Checklist(string name, string description, int points, int baseAmnt, int bonus) : base (name, description, points)
    {
       _baseAmnt = baseAmnt;
       _bonus = bonus;
       _amntCompleted = 0;
       _isComplete = false;
    }


    public Checklist(string name, string description, int points, bool isComplete, int amntCompleted, int baseAmnt, int bonus) : base (name, description, points)
    {
       _baseAmnt = baseAmnt;
       _bonus = bonus;
       _amntCompleted = 0;
       _isComplete = false;
    }



    public override void RecordEvent()
    {
        // _amntComplete ++
        // IF _amntCompleted == _baseAmnt
        //      _isComplete -> TRUE
        //      PUT Message
        //      RETURN _points + _bonus
        // ELSE
        //      PUT Message
        //      RETURN _points
    }
    public override bool IsComplete()
    {
        //return true if goal is completed
        //determine if a goal is complete depending on the goal type
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" {_amntCompleted}/{_baseAmnt}";
    }
    public override string GetSaveString()
    {
        return base.GetSaveString() + $"|{_isComplete}|{_amntCompleted}|{_baseAmnt}|{_bonus}";
    }
}