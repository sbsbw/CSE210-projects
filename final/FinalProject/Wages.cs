using System;

public class Wages : Income
{
    private float _rate;
    private float _hours;
    public Wages()
    {

    }
    public Wages(string savedString)
    {
        string[] parts = savedString.Split("|");
        _dataType = int.Parse(parts[0]);
        _amount = float.Parse(parts[1]);
        _description = parts[2];
        _hours = float.Parse(parts[3]);
        _rate = float.Parse(parts[4]);
    }
    public override void SetAttributes()
    {
        Console.Clear();
        _dataType = 2;
        Console.Write("Please type the description of work done: ");
        _description = Console.ReadLine();
        Console.Write("How much do you get paid per hour? ");
        _rate = float.Parse(Console.ReadLine());
        Console.Write("How many hours did you work? ");
        _hours = float.Parse(Console.ReadLine());
        _amount = _rate * _hours;
    }
    public override string StringToSave()
    {
        return $"2|{_amount}|{_description}|{_hours}|{_rate}";
    }
    public override string ShowInfo()
    {
        return $"+ ${_amount} ({_description} for {_hours} at ${_rate} per hour.)";
    }
}