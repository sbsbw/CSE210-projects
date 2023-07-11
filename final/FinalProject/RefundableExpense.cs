using System;

public class RefundableExpense : Expense
{
    bool _refunded;
    public RefundableExpense()
    {
        
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
        _dataType = 5;
        Console.Write("Please describe the reason for the expense: ");
        _description = Console.ReadLine();
        Console.Write("How much money will you pay? ");
        _amount = float.Parse(Console.ReadLine()) * -1;
        _dueDate = DateTime.Today.ToString();
        _paid = false;
        _refunded = false;
    }
    public override string StringToSave()
    {
        return $"5|{_amount}|{_description}|{_dueDate}|{_paid}|{_refunded}";
    }
    public override string ShowInfo()
    {
        return $" ${_amount} ({_description} === Due on: {_dueDate} === Paid: {_paid} === Refunded: {_refunded})";
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