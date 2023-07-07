using System;

public class Expense : Data
{
    protected DateTime _dueDate;
    protected bool _paid;
    public Expense()
    {
        
    }
    public Expense(string savedString)
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
    public float PayExpense()
    {
        _paid = true;
        return _amount * -1;
    }
}