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
      _name = parts[1];
      _description = parts[2];
      _points = int.Parse(parts[3]);
   }

}