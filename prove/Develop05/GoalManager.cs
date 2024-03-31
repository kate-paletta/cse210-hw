
public class GoalManager
{
    private List<Goal> goals = new();
    private int _score;
    private int _userChoice;
    private int _goalType;
    public GoalManager()
    {
       _score = 0;
       //list empty

    }

    public void Start()
    {
        //runs the menu loop
        while (_userChoice != 5)
        {
            DisplayScore();
            Console.WriteLine(" ");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            _userChoice = int.Parse(Console.ReadLine());

            if (_userChoice == 1)
            {
                CreateGoal();
            }
            else if (_userChoice == 2)
            {
                //list goals
            }
            else if (_userChoice ==3)
            {
                SaveGoals();
            }
            else if (_userChoice == 4)
            {
                LoadGoals();
            }
            else if (_userChoice == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
            }

        }
    }
    public void DisplayScore()
    {
        //shows current score
        Console.WriteLine($"You have {_score} points");
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
        Console.Write("Select goal type:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");

        _goalType = int.Parse(Console.ReadLine());

        
        if (_goalType == 1)
        {
            Simple simple = new("","",0);
            simple.GetGoalDetails();
            goals.Add(simple);
        }
        else if (_goalType == 2)
        {
            Eternal eternal = new("","",0);
            eternal.GetGoalDetails();
            goals.Add(eternal);
        }
        else if (_goalType == 3)
        {
            Checklist checklist = new("","",0);
            checklist.GetGoalDetails();
            goals.Add(checklist);
        }

        
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