using System;

public class ConsistantExpense : Expense
{
    private int _frequency;
    public ConsistantExpense()
    {
        SetAttributes();
    }
    public ConsistantExpense(string savedString)
    {
        string[] parts = savedString.Split("|");
        _dataType = int.Parse(parts[0]);
        _amount = float.Parse(parts[1]);
        _description = parts[2];
        _dueDate = parts[3];
        _frequency = int.Parse(parts[4]);
    }
    public override void SetAttributes()
    {
        Console.Clear();
        Console.Write("Please describe the reason for the expense: ");
        _description = Console.ReadLine();
        Console.Write("How much money did you pay? ");
        _amount = float.Parse(Console.ReadLine()) * -1;
        _dueDate = DateTime.Today.ToString();
        _paid = false;
        Console.Write("How many times will this charge accure in a year?  ");
        _frequency = int.Parse(Console.ReadLine());
    }
    public override string StringToSave()
    {
        return $"3|{_amount}|{_description}|{_dueDate}|{_paid}|{_frequency}";
    }
    public override string ShowInfo()
    {
        return $"- ${_amount} ({_description} === Due on: {_dueDate} === Paid this period: {_paid} === Will be due again {365/_frequency} days after due date.)";
    }
    public override float GetAmount()
    {
        DateTime tempDate = DateTime.Today.AddDays(365/_frequency);
        _dueDate = tempDate.ToString();
        return _amount;
    }
}