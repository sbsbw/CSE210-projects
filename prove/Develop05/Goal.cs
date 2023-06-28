using System;

public class Goal
{
    // Define the attributes.
    protected string _description;
    protected string _name;
    protected int _points;

    // Write methods for your Goal.
    public virtual int Complete()
    {
        return _points;
    }

    public int GetVaildInt(string prompt, int upperBound)
    {
        int number = -1;
        int finished = 0;
        while (finished == 0)
        {   
            Console.WriteLine();
            Console.Write(prompt);
            try
            {
            number = int.Parse(Console.ReadLine());
            if ((number > 0) || (number <= upperBound))
            {
                return number;
            }
            else
            {
                Console.WriteLine("This is not a valid input, Please Try again");
            }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        return 0;
    }

    public Goal()
    {
        SetGoalAttributes();
    }

    public Goal(string savedString)
    {
        string[] parts = savedString.Split("|");
        _name = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
    }

    public virtual void SetGoalAttributes()
    {
        Console.Clear();
        Console.Write("What is the name of your Goal? ");
        _name = Console.ReadLine();
        Console.Write("Write a short description of your Goal? ");
        _description = Console.ReadLine();
        _points = GetVaildInt("How many points do you get with this goal?", 100);
    }

    public virtual string ToSavedString()
    {
        return $"2|{_name}|{_description}|{_points}";
    }

    public virtual string ConvertToString()
    {
        return $"[ ] {_name} ({_description}) worth {_points} points.";
    }
}