using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    { 
        Console.WriteLine("\nWelcome to the Eternal Quest program! \nPlease make a selection to get started!\n");
        int userSelection = 0;

        while (userSelection != 6)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals from File \n5. Record Event \n6. Quit");
            Console.WriteLine("Selection: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break; //double check output specifics
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": userSelection = 6; break;
                default:
                    Console.WriteLine("\n*********************\nError: Entry is not a numerical option. Please try again.\n*********************\n");
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Points: {_score}\n");
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetType().Name}"); //numbered?
        }
    }
    public void ListGoalDetails()
    {
        int i = 0;
        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");//numbered?
        }
    }
    public void CreateGoal()
    {
        int Option;
        Console.WriteLine("What type of goal would you like to create?");
        Console.Write("1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal ");
        bool option = int.TryParse(Console.ReadLine(), out Option);

        if (Option == 1)
        {
            int goalPoints;
            Console.Write("\nWhat is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("\nWhat is a short description of your goal? ");
            string goalDesc = Console.ReadLine();
            Console.Write("What is the point value for completing this goal? ");
            bool value = int.TryParse(Console.ReadLine(), out goalPoints);
            if (goalPoints > 0)
            {
                SimpleGoal s1 = new SimpleGoal(goalName, goalDesc, goalPoints);
                _goals.Add(s1);
            }
            else
            {
                Console.WriteLine("\n*********************\nError: Entry is not a numerical option. Please try again.\n*********************\n");
            }
        }

        else if (Option == 2)
        {
            int goalPoints;
            Console.Write("\nWhat is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("\nWhat is a short description of your goal? ");
            string goalDesc = Console.ReadLine();
            Console.Write("What is the point value for completing this goal? ");
            bool value = int.TryParse(Console.ReadLine(), out goalPoints);
            if (goalPoints > 0)
            {
                EternalGoal e1 = new EternalGoal(goalName, goalDesc, goalPoints);
                _goals.Add(e1);
            }
            else
            {
                Console.WriteLine("\n*********************\nError: Entry is not a numerical option. Please try again.\n*********************\n");
            }
        }

        else if (Option == 3)
        {
            int goalPoints;
            Console.Write("\nWhat is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("\nWhat is a short description of your goal? ");
            string goalDesc = Console.ReadLine();
            Console.Write("What is the point value for completing this goal? ");
            bool value = int.TryParse(Console.ReadLine(), out goalPoints);
            if (goalPoints > 0)
            {
                int num;
                Console.Write("How many times does this goal need to be completed to be accomplished? ");
                value = int.TryParse(Console.ReadLine(), out num);
                if (num > 0)
                {
                    int bonus;
                    Console.Write("What will the the bonus for accomplishing it that many times? ");
                    value = int.TryParse(Console.ReadLine(), out bonus);
                    if (bonus > 0)
                    {
                        ChecklistGoal cL1 = new ChecklistGoal(goalName, goalDesc, goalPoints, num, bonus);
                        _goals.Add(cL1);
                    }
                    else
                    {
                        Console.WriteLine("\n*********************\nError: Entry is not a numerical option. Please try again.\n*********************\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n*********************\nError: Entry is not a numerical option. Please try again.\n*********************\n");
                }
            }
            else
            {
                Console.WriteLine("\n*********************\nError: Entry is not a numerical option. Please try again.\n*********************\n");
            }
        }
        else
        {
            Console.WriteLine("\n*********************\nError: Entry is not a numerical option. Please try again.\n*********************\n");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        //needs to load to a file. 
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nWhich goal did you accomplish? ");
        int goalNum = int.Parse(Console.ReadLine());
        //need to know how to capture type... index through list somehow
        //will need to complete sub classes methods for recording 
    }
    public void LoadGoals()
    {
        Console.Write("\nEnter filename to load: ");
        string filename = Console.ReadLine();
        //needs to be able to retrieve from file and print
    }
}