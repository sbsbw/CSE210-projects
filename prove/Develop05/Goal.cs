using System;

public class Goal
{
    // Define the attributes.
    protected string _description;
    protected string _name;
    protected int _points;

    // Write methods for your Goal.
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public virtual int Complete()
    {
        return 0;
    }

    public int GetVaildInt(string prompt)
    {
        return 0;
    }

    public Goal()
    {
        _name = "Unnamed Goal";
        _description = "No Description";
        _points = 0;
    }

    public Goal(string savedString)
    {
        _name = "Unnamed Goal";
        _description = savedString;
        _points = 0;
    }

    public virtual void SetGoalAttributes()
    {

    }

    public virtual string ToSavedString()
    {
        return "";
    }

    public virtual string ConvertToString()
    {
        return "";

    }
}