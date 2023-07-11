using System;

public class Income : Data
{
    public Income()
    {
        SetAttributes();
    }
    public Income(string savedString)
    {
        string[] parts = savedString.Split("|");
        _dataType = int.Parse(parts[0]);
        _amount = float.Parse(parts[1]);
        _description = parts[2];
    }
    public override void SetAttributes()
    {
        Console.Clear();
        _dataType = 1;
        Console.Write("Please describe the source of the income: ");
        _description = Console.ReadLine();
        Console.Write("How much money did you gain? ");
        _amount = float.Parse(Console.ReadLine());
    }
    public override string StringToSave()
    {
        return $"1|{_amount}|{_description}";
    }
    public override string ShowInfo()
    {
        return $"+ ${_amount} ({_description})";
    }
}