using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _playerScore;
    private int _nextId;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _playerScore = 0;
        _nextId = 1;
    }

    public int GetNextId()
    {
        return _nextId++;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayPlayerScore()
    {
        Console.WriteLine($"Player's Score: {_playerScore}");
    }

    public void IncreasePlayerScore(int bonusPoints)
    {
        _playerScore += bonusPoints;
    }

    public void CreateGoal(string name, string description, int points)
    {
        Goal newGoal = new SimpleGoal(name, description, points, GetNextId(), this);
        _goals.Add(newGoal);
    }

    public void RecordEvent(int goalNumber)
    {
        if (goalNumber >= 1 && goalNumber <= _goals.Count)
        {
            Goal goal = _goals[goalNumber - 1]; 
            goal.RecordEvent();
            _playerScore += goal.GetPoints();
            DisplayPlayerScore();
            Console.WriteLine($"Event recorded successfully for goal '{goal.GetName()}'.");
        }
        else
        {
            Console.WriteLine("Error: Invalid goal number.");
        }
    }

    public void ShowGoalList()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string checkbox = _goals[i].IsComplete() ? "[X]" : "[]";
            Console.WriteLine($"{i + 1}. {checkbox} {_goals[i].GetDetailsString()}");
        }
    }

    public void SaveGoalsToFile()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved to file successfully!");
    }

    public void LoadGoalsFromFile()
    {
        _goals.Clear();

        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(';');
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);

                Goal goal = new SimpleGoal(name, description, points, GetNextId(), this);
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded from file successfully!");
    }

    public void CreateEternalGoal(string name, string description, int points)
    {
        Goal newGoal = new EternalGoal(name, description, points, GetNextId(), this);
        _goals.Add(newGoal);
    }

    public void CreateChecklistGoal(string name, string description, int points, int target, int bonus)
    {
        Goal newGoal = new ChecklistGoal(name, description, points, target, bonus, GetNextId(), this);
        _goals.Add(newGoal);
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }
}
