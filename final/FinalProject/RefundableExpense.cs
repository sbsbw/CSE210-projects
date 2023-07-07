using System;

public class RefundableExpense : Data
{
    public RefundableExpense()
    {
        
    }
    public RefundableExpense(string savedString)
    {

    }
    public override void SetAttributes()
    {

    }
    public float GetAmount()
    {
        return _amount;
    }
    public DateTime GetDueDate()
    {
        return _dueDate;
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