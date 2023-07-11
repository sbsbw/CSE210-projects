using System;

public class RefundableExpense : Expense
{
    bool _refunded;
    public RefundableExpense()
    {
        SetAttributes();
    }
    public RefundableExpense(string savedString)
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
        if (parts[5] == "true")
        {
            _refunded = true;
        }
        else
        {
            _refunded = false;
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
        _paid = false;
        _refunded = false;
    }
    public override string StringToSave()
    {
        return $"4|{_amount}|{_description}|{_dueDate}|{_paid}";
    }
    public override string ShowInfo()
    {
        return $"- ${_amount} ({_description} === Due on: {_dueDate} === Paid: {_paid})";
    }
    public override float GetAmount()
    {
        if (_refunded == false)
        {
            if (_paid == false)
            {
                _paid = true;
                return _amount;
            }
            else
            {
                _refunded = true;
                return _amount * -1;
            }
        }
        else
        {
            return 0;
        }

    }
}