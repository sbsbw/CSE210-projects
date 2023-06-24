using System;

public class SimpleGoal : CompletableGoal
{

   // CompletableGoal Constructor.
   public SimpleGoal()
   {
    
   }

   public SimpleGoal(string savedString)
   {
    
   }

   // Overide previous Methods from parent class.
   public override int Complete()
   {
    return 0;
   }
}