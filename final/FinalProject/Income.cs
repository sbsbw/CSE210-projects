using System;

public class Income : Data
{
    public Income()
    {
        SetAttributes();
    }
    public Income(string savedString)
    {

    }
    public override void SetAttributes()
    {
        Console.Clear();
        Console.Write("Please describe the source of the income: ");
        _description = Console.ReadLine();
        Console.Write("How much money did you gain? ");
        _amount = float.Parse(Console.ReadLine());
    }
    public override string StringToSave()
    {
        return "";
    }
    public override string ShowInfo()
    {
        return "";
    }
}