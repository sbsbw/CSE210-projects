using System;

public class BreathingAcivity : Activity
{
    // Create the constructor for the breathing activity.
    public BreathingAcivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void ShowBreathInMessage()
    {
        Console.WriteLine($"\r\n There are {_duration} seconds left in the exersice.\r\n");
        Console.Write($"Breathe in...  ");
        ShowCountdownTimer(4);
        _duration = _duration - 4;
    }

    public void ShowBreathOutMessage()
    {
        Console.WriteLine($"\r\n There are {_duration} seconds left in the exersice.\r\n");
        Console.Write("Breathe out...  ");
        ShowCountdownTimer(4);
        _duration = _duration - 4;
    }

    public void Run()
    {   
        DisplayStartingMessage();
        Console.Write("Get ready...  ");
        ShowCountdownTimer(5);
        while (_duration > 0)
        {
            ShowBreathInMessage();
            ShowBreathOutMessage();
        }
        DisplayEndingMessage();
    }
}