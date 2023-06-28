using System;

public class CompletableGoal : Goal
{
   // Define attributes for CompletableGoal.
   protected int _isComplete;

   // CompletableGoal Constructor.
   public CompletableGoal()
   {
        SetGoalAttributes();
        _isComplete = 0;
   }

   public CompletableGoal(string savedString)
   {
        string[] parts = savedString.Split("|");
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _isComplete = int.Parse(parts[4]);
   }

   // Overide previous Methods from parent class.
    public override string ToSavedString()
    {
        return $"1|{_name}|{_description}|{_points}|{_isComplete}";
    }

    public override string ConvertToString()
    {
        if (_isComplete == 0)
        {
            return $"[ ] {_name} ({_description}) worth {_points} points.";
        }
        else
        {
            return $"[X] {_name} ({_description}) worth {_points} points.";
        }

    }
}