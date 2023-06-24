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

    }

    public ChecklistGoal(string savedString)
    {

    }

    // Overide previous Methods from parent class.
    public override int Complete()
    {
    return 0;
    }
    public override void SetGoalAttributes()
    {

    }

    public override string ToSavedString()
    {
    return "";
    }

    public override string ConvertToString()
    {
    return "";

    }
}