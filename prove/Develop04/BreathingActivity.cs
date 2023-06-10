using System;

public class BreathingAcivity : Activity
{
    // Create attribute for breathe  timer.
    int _breatheTimer;
    // Create the constructor for the breathing activity.
    public BreathingAcivity(int duration)
    {
        _name = "Breathing Activity";
        _duration = duration;
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void ShowBreathInMessage()
    {
        Console.WriteLine($"\r\n There are {_duration} seconds left in the exersice.\r\n");
        Console.Write($"Breathe in...  ");
        _breatheTimer = 4;
        while (_breatheTimer > 0)
        {
            Console.Write(_breatheTimer);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            _breatheTimer --;
        }
        _duration = _duration - 4;
    }

    public void ShowBreathOutMessage()
    {
        Console.WriteLine($"\r\n There are {_duration} seconds left in the exersice.\r\n");
        Console.Write("Breathe out...  ");
        _breatheTimer = 4;
        while (_breatheTimer > 0)
        {
            Console.Write(_breatheTimer);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            _breatheTimer --;
        }
        _duration = _duration - 4;
    }

    public void run()
    {   
        
        while (_duration > 0)
        {

        }
    }
}