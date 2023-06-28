using System;

public class GoalData
{
    // Define attributes for class.
    private List<Goal> _goals = new List<Goal>();
    private int _totalXP;
    private Menu menu;
    // Make methods for the class.
    public void AddGoal()
    {   
        int userChoice = menu.DisplayGoalMenu();
        if (userChoice == 1)
        {
            SimpleGoal SG = new SimpleGoal();
            _goals.Add(SG);
        }
        else if (userChoice == 2)
        {
            EternalGoal EG = new EternalGoal();
            _goals.Add(EG);
        }
        else if (userChoice == 3)
        {
            ChecklistGoal CG = new ChecklistGoal();
            _goals.Add(CG);
        }
    }

    public int AddPoints(int points)
    {
        return 0;
    }
    
    public void CompleteGoal(int goalNumber)
    {
        
    }

    public void GetGoalList()
    {
        
    }

    public void Load(string fileName)
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            _goals.Clear();
            _totalXP = 0;
            int _goalType = 0;
            int i = 0;
            foreach (string line in lines)
            {
                if (i == 0)
                {   
                    string[] parts = line.Split("|");
                    _goalType = int.Parse(parts[0]);
                    _totalXP = int.Parse(parts[1]);
                    i++;
                }
                else
                {
                    if (_goalType == 1)
                    {
                    string[] parts = line.Split("|");
                    SimpleGoal goal = new SimpleGoal(line);
                    _goals.Add(goal);
                    }
                    else if (_goalType == 2)
                    {
                    string[] parts = line.Split("|");
                    EternalGoal goal = new EternalGoal(line);
                    _goals.Add(goal);
                    }
                    else if (_goalType == 3)
                    {
                    string[] parts = line.Split("|");
                    ChecklistGoal goal = new ChecklistGoal(line);
                    _goals.Add(goal);
                    }
                }
            }
        }
        catch
        {
            Console.WriteLine("We could not find this file.");
        }

    }
    public void Save(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_totalXP}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.ToSavedString());
            }
        }
    }

    public void ShowGoals()
    {   
        Console.Clear();
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($" {i}. {goal.ConvertToString()}");
            i++;
        }
    }
}