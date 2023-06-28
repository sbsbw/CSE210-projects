using System;

public class ChecklistGoal : CompletableGoal
{
    // Define attributes.
    private int _bonus;
    private int _numberToComplete;
    private int _timesCompleted;

    // CompletableGoal Constructor.
    public ChecklistGoal()
    {
        SetGoalAttributes();
    }

    public ChecklistGoal(string savedString)
    {
        string[] parts = savedString.Split("|");
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _isComplete = int.Parse(parts[4]);
        _bonus = int.Parse(parts[5]);
        _numberToComplete = int.Parse(parts[6]);
        _timesCompleted = int.Parse(parts[7]);
    }

    // Overide previous Methods from parent class.
    public override int Complete()
    {
        _timesCompleted++;
        if (_timesCompleted != _numberToComplete)
        {
            return _points;
        }
        else
        {
            _isComplete = 1;
            Console.Clear();
            Console.WriteLine("Congrats! You have completed the bonus!");
            Thread.Sleep(6000);
            Console.WriteLine(@"""
            
            
            
            

                    |
            """);
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Congrats! You have completed the bonus!");
            Console.WriteLine(@"""
            
            
            
            
                    |
                    
            """);
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Congrats! You have completed the bonus!");
            Console.WriteLine(@"""
            
            
            
                    |
                    
                    
            """);
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Congrats! You have completed the bonus!");
            Console.WriteLine(@"""
            
            
                    *
                    
                    
                    
            """);
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Congrats! You have completed the bonus!");
            Console.WriteLine(@"""
            
                    \ /
                   --*--
                    / \
                    
                    
            """);
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Congrats! You have completed the bonus!");
            Console.WriteLine(@"""
                   \   /
                    \ /
                -----*-----
                    / \
                   /   \
                    
            """);
            Thread.Sleep(500);
            return _points + _bonus;
        }
    }
    public override void SetGoalAttributes()
    {
        Console.Clear();
        Console.Write("What is the name of your Goal? ");
        _name = Console.ReadLine();
        Console.Write("Write a short description of your Goal? ");
        _description = Console.ReadLine();
        _points = GetVaildInt("How many points do you get with this goal? (<100) ", 100);
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _numberToComplete = int.Parse(Console.ReadLine());
        _bonus = GetVaildInt("What is the bonus for accomplishing it that number of times?  (<200) ", 200);        
        _timesCompleted = 0;
        _isComplete = 0;
    }

    public override string ToSavedString()
    {
        return $"3|{_name}|{_description}|{_points}|{_isComplete}|{_bonus}|{_numberToComplete}|{_timesCompleted}";
    }

    public override string ConvertToString()
    {
        if (_isComplete == 0)
        {
            return $"[ ] {_name} ({_description}) worth {_points} points. -- Currently completed: {_timesCompleted}/{_numberToComplete}";
        }
        else
        {
            return $"[X] {_name} ({_description}) worth {_points} points. -- Currently completed: {_timesCompleted}/{_numberToComplete}";
        }
    }
}