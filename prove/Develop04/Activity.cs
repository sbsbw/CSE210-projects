using System;

public class Activity
{
    // Define Class attributes:
    protected string _name;
    protected int _duration;
    protected string _description;

    // Make Class constructors:
    public Activity()
    {
        _name = "";
        _duration = 5;
        _description = "";
    }
    public Activity(string name, int duration, string description)
    {
        _name = name;
        _duration = duration;
        _description = description;
    }

    // Define Class Methods:
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}Activity.\r\n");
        Console.WriteLine(_description);
    }


    public void GetDuration()
    {
        Console.Write("\r\nHow long (in seconds < 100 and > 0) would you like your session to be?  ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void ShowCountdownTimer()
    {
        int seconds = _duration;
            while (seconds > 9)
            {
                Console.Write(seconds);
                Thread.Sleep(5000);
                Console.Write("\b\b  \b\b");

                seconds = seconds - 5;
            }

            while (seconds > 0)
            {
                Console.Write(seconds);
                Thread.Sleep(1000);
                Console.Write("\b \b");

                seconds --;
            }

            Console.WriteLine("\nDone.");
    }
}