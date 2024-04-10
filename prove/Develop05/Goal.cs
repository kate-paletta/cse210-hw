using System;
using System.Collections.Generic;
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
    public abstract int RecordEvent();

    private char GetIsCompleteChar()
    {
        // TENARY OPERATOR
        //     CONDITION ? TRUE : FALSE
        return IsComplete() ? 'X' : ' ';
    }
    public virtual string GetDetailsString()
    {
        return $"[{GetIsCompleteChar()}] {_shortName} - {_description}";
    }
    public virtual string GetSaveString()
    {
        return $"{GetType()}|{_shortName}|{_description}|{_points}";
    }

    public virtual bool IsComplete()
    {
        return false;
    }
}