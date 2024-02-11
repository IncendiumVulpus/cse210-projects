using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Welcome to Goal Tracker App!");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoalMenu(goalManager);
                    break;
                case "2":
                    goalManager.ShowGoalList();
                    break;
                case "3":
                    goalManager.SaveGoalsToFile();
                    break;
                case "4":
                    goalManager.LoadGoalsFromFile();
                    break;
                case "5":
                    RecordEventMenu(goalManager);
                    break;
                case "6":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Thank you for using Goal Tracker App!");
    }

    static void CreateGoalMenu(GoalManager goalManager)
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalTypeChoice = Console.ReadLine();

        switch (goalTypeChoice)
        {
            case "1":
                CreateSimpleGoal(goalManager);
                break;
            case "2":
                CreateEternalGoal(goalManager);
                break;
            case "3":
                CreateChecklistGoal(goalManager);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    static void CreateSimpleGoal(GoalManager goalManager)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for completing the goal: ");
        int points = int.Parse(Console.ReadLine());

        //int nextId = goalManager.GetNextId();
        goalManager.CreateGoal(name, description, points);
        Console.WriteLine("Simple Goal created successfully!");
        DisplayPlayerScore(goalManager);
    }

    static void CreateEternalGoal(GoalManager goalManager)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for each event: ");
        int points = int.Parse(Console.ReadLine());

        //int nextId = goalManager.GetNextId();
        goalManager.CreateEternalGoal(name, description, points);
        Console.WriteLine("Eternal Goal created successfully!");
        DisplayPlayerScore(goalManager);
    }

    static void CreateChecklistGoal(GoalManager goalManager)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for each event: ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("Enter target number of completions: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points upon completion: ");
        int bonus = int.Parse(Console.ReadLine());

        //int nextId = goalManager.GetNextId();
        goalManager.CreateChecklistGoal(name, description, points, target, bonus);
        Console.WriteLine("Checklist Goal created successfully!");
        DisplayPlayerScore(goalManager);
    }

    static void RecordEventMenu(GoalManager goalManager)
    {
        Console.Write("Enter the number of the goal you accomplished: ");
        if (int.TryParse(Console.ReadLine(), out int goalNumber))
        {
            goalManager.RecordEvent(goalNumber);
            Console.WriteLine("Event recorded successfully!");
            DisplayPlayerScore(goalManager);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
        }
    }

    static void DisplayPlayerScore(GoalManager goalManager)
    {
        goalManager.DisplayPlayerScore();
    }
}
