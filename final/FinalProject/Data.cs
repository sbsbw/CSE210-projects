using System;

public class Data
{
    public int _dataType;
    protected string _description;
    protected float _amount;

    public virtual void SetAttributes()
    {

    }
    public virtual float GetAmount()
    {
        return _amount;
    }
    public virtual string StringToSave()
    {
        return "";
    }
    public virtual string ShowInfo()
    {
        return "";
    }
}