using System;

public class Data
{
    protected string _description;
    protected float _amount;

    public Data()
    {
        
    }
    public Data(string savedString)
    {

    }
    public virtual void SetAttributes()
    {

    }
    public float GetAmount()
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