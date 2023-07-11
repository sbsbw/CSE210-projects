using System;

public class Expense : Data
{
    protected string _dueDate;
    protected bool _paid;
    public Expense()
    {
        SetAttributes();
    }
    public Expense(string savedString)
    {
        string[] parts = savedString.Split("|");
        _dataType = int.Parse(parts[0]);
        _amount = float.Parse(parts[1]);
        _description = parts[2];
        _dueDate = parts[3];
        if (parts[4] == "true")
        {
            _paid = true;
        }
        else
        {
            _paid = false;
        }
    }
    public override void SetAttributes()
    {
        Console.Clear();
        Console.Write("Please describe the reason for the expense: ");
        _description = Console.ReadLine();
        Console.Write("How much money did you pay? ");
        _amount = float.Parse(Console.ReadLine()) * -1;
        _dueDate = DateTime.Today.ToString();
        _paid = true;
    }
    public override string StringToSave()
    {
        return $"2|{_amount}|{_description}|{_dueDate}|{_paid}";
    }
    public override string ShowInfo()
    {
        return $"- ${_amount} ({_description} === Due on: {_dueDate} === Paid: {_paid})";
    }
    public override float GetAmount()
    {
        if (!_paid)
        {
            _paid = true;
            return _amount;
        }
        else
        {
            return 0;
        }
    }
    public string GetDueDate()
    {
        return _dueDate;
    }
}