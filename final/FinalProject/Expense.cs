using System;

public class Expense : Data
{
    protected DateTime _dueDate;
    protected bool _paid;
    public Expense()
    {
        SetAttributes();
    }
    public Expense(string savedString)
    {

    }
    public override void SetAttributes()
    {
        Console.Clear();
        Console.Write("Please describe the reason for the expense: ");
        _description = Console.ReadLine();
        Console.Write("How much money did you pay? ");
        _amount = float.Parse(Console.ReadLine()) * -1;
        _dueDate = DateTime.Now;
        _paid = true;

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
        return _amount;
    }
        public DateTime GetDueDate()
    {
        return _dueDate;
    }
}