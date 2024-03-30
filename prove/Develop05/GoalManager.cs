using System.Reflection;

public class GoalManager
{
    private List<Goal> goals = new();
    private int _score;
    public GoalManager()
    {
       _score = 0;
       //list empty

    }

    public void Start()
    {
        //runs the menu loop
    }
    public void DisplayScore()
    {
        //dhows current score
    }
    public void ListShortName()
    {
        //stores short name
    }
    public void ListDetails()
    {
        //includes checkbox if completed
    }
    public void CreateGoal()
    {
        //asks user for info about new goal adds to list
    }
    public void RecordEvent()
    {
        //asks user which goal they have done call RecordEvent method
    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {
        
    }
}