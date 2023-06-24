using System;

public class CompletableGoal : Goal
{
   // Define attributes for CompletableGoal.
   int _isComplete;

   // CompletableGoal Constructor.
   public CompletableGoal()
   {
    
   }

   public CompletableGoal(string savedString)
   {
    
   }

   // Overide previous Methods from parent class.
    public override string ToSavedString()
    {
    return "";
    }

    public override string ConvertToString()
    {
    return "";

    }
}