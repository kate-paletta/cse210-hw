
public class GoalManager
{
    private List<Goal> goals = new();
    private int _score;

    public GoalManager()
    {
       _score = 0;
       //list empty

    }
  
    public string DisplayScore()
    {
        //shows current score
        return $"You have {_score} points";
    }

    public void DisplayGoals()
    {
        // counter -> 1
        // FOREACH goal in goals
        //      PUT counter) goal.GetDetailsString()
        //      counter++
    }

    public void CreateGoal()
    {
        //asks user for info about new goal adds to list
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");

        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();
        Console.Write("Please describe your goal: ");
        string description = Console.ReadLine();
        Console.Write("How many points will you earn when completed? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case 1: 
                Simple simple = new(shortName, description, points);
                simple.GetGoalDetails();
                goals.Add(simple);
                break;
            case 2:
                Eternal eternal = new(shortName, description, points);
                eternal.GetGoalDetails();
                goals.Add(eternal);
                break;
            case 3:
                Console.Write("What is the target amount to complete the goal? ");
                int baseAmnt = int.Parse(Console.ReadLine());
                Console.Write("When you've completed all of your tasks how many points would like to earn? ");
                int bonus = int.Parse(Console.ReadLine());
                Checklist checklist = new(shortName, description, points, baseAmnt, bonus);
                goals.Add(checklist);
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }

        
    }
    public void RecordEvent()
    {
        // DisplayGoal()
        // PUT Select a goal
        // choice -> GET
        // _score += goals[choice - 1].RecordEvent()
    }
    public void SaveGoals()
    {
        
    }
    public void LoadGoals()
    {

    }
}