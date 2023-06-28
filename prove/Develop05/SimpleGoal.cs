using System;

public class SimpleGoal : CompletableGoal
{

   // SimpleGoal Constructor.
   public SimpleGoal()
   {
      SetGoalAttributes();
      _isComplete = 0;
   }

   public SimpleGoal(string savedString)
   {
         string[] parts = savedString.Split("|");
         _name = parts[1];
         _description = parts[2];
         _points = int.Parse(parts[3]);
         _isComplete = int.Parse(parts[4]);
   }

   // Overide previous Methods from parent class.
   public override int Complete()
   {
    _isComplete = 1;
    return _points;
   }
}