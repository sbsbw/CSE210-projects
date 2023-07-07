using System;

public class FlexibleExpense : Expense
{
    private float _upperLimit;
    private float _lowerLimit;
    public FlexibleExpense()
    {
        
    }
    public FlexibleExpense(string savedString)
    {

    }
    public override void SetAttributes()
    {

    }
    public override string StringToSave()
    {
        return "";
    }
    public override string ShowInfo()
    {
        return "";
    }
}