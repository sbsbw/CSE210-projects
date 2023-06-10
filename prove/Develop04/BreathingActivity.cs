using System;

public class BreathingAcivity : Activity
{
    // Make a attribute to track remaining seconds.
    int _remainingTime;

    // Create the constructor for the breathing activity.
    public BreathingAcivity()
    {
        _name = "Breathing Activity";
        _remainingTime = 0;
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void ShowBreathInMessage()
    {
        Console.WriteLine($"\r\n There are {_remainingTime} seconds left in the exersice.\r\n");
        Console.Write($"Breathe in...  ");
        ShowCountdownTimer(4);
        _remainingTime = _remainingTime - 4;
    }

    public void ShowBreathOutMessage()
    {
        Console.WriteLine($"\r\n There are {_remainingTime} seconds left in the exersice.\r\n");
        Console.Write("Breathe out...  ");
        ShowCountdownTimer(4);
        _remainingTime = _remainingTime - 4;
    }

    public void Run()
    {   
        DisplayStartingMessage();
        _remainingTime = _duration + (8 - (_duration % 8));
        Console.Write("Get ready...  ");
        ShowCountdownTimer(3);
        while (_remainingTime > 0)
        {
            ShowBreathInMessage();
            ShowBreathOutMessage();
        }
        DisplayEndingMessage();
    }
}