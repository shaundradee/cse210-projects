using System;
using System.Reflection.Metadata.Ecma335;
using System.IO;

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
            Console.Write("Selection: ");
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
                    Console.WriteLine("\n*********************\nError: Entry is not a valid option. Please try again.\n*********************\n");
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
        Console.WriteLine();
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine();
        int i = 0;
        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        string errMessage = "\n*********************\nError: Entry is not a valid option. Please try again.\n*********************\n";
        int Option;
        Console.WriteLine("\nWhat type of goal would you like to create?");
        Console.Write("1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal ");
        if (!int.TryParse(Console.ReadLine(), out Option))
        {
            Console.WriteLine(errMessage);
        }
        else
        {
            Console.Write("\nWhat is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("\nWhat is a short description of your goal? ");
            string goalDesc = Console.ReadLine();
            Console.Write("\nWhat is the point value for completing this goal? ");
            if (!int.TryParse(Console.ReadLine(), out int goalPoints) || goalPoints <= 0)
            {
                Console.WriteLine(errMessage);
            }
            else
            {
                switch (Option)
                {
                    case 1:
                        SimpleGoal s1 = new(goalName, goalDesc, goalPoints);
                        _goals.Add(s1);
                        break;
                    case 2:
                        EternalGoal e1 = new(goalName, goalDesc, goalPoints);
                        _goals.Add(e1);
                        break;
                    case 3:
                        Console.Write("How many times does this goal need to be completed to be accomplished? ");
                        if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
                        {
                            Console.Write("What will the the bonus for accomplishing it that many times? ");
                            if (int.TryParse(Console.ReadLine(), out int bonus) && bonus > 0)
                            {
                                ChecklistGoal cL1 = new(goalName, goalDesc, goalPoints, num, bonus);
                                _goals.Add(cL1);
                            }
                            else
                            {
                                Console.WriteLine(errMessage);
                            }
                        }
                        else
                        {
                            Console.WriteLine(errMessage);
                        }
                        break;
                    default:
                        Console.WriteLine(errMessage);
                        break;

                }
            }
        }

    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("\nGoals saved successfully.");
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nWhich goal did you accomplish? ");
        if (!int.TryParse(Console.ReadLine(), out int goalNum) || goalNum <= 0 || goalNum > _goals.Count)
        {
            Console.WriteLine("\n*********************\nError: Entry is not a valid option. Please try again.\n*********************\n");
        }
        else
        {
            var goal = _goals[goalNum - 1];
            goal.RecordEvent();
            Console.WriteLine(goal.CongratsMessage());
            _score += goal.GetPoints();
            Console.WriteLine("Don't forget to check out your new total!\n");
        }
    }
    public void LoadGoals()
    {
        Console.Write("\nEnter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
        }
        else
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                if (type == "SimpleGoal")
                {
                    var g = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.Parse(parts[4]))
                    {
                        g.RecordEvent(); // mark complete if needed
                    }
                    _goals.Add(g);
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (type == "ChecklistGoal")
                {
                    var g = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]));
                    for (int j = 0; j < int.Parse(parts[6]); j++)
                    {
                        g.RecordEvent();
                    }
                    _goals.Add(g);
                }
            }

            Console.WriteLine("\nGoals loaded successfully.\n");
        }
    }
}
