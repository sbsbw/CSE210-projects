using System;

public class EternalGoal : Goal
{
   

   // Create Constructors for EternalGoal.
   public EternalGoal()
   {
        SetGoalAttributes();
   }

   public EternalGoal(string savedString)
   {
      string[] parts = savedString.Split("|");
      _name = parts[0];
      _description = parts[1];
      _points = int.Parse(parts[2]);
   }

}