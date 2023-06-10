using System;

public class ListAcivity : Activity
{
    // Create a list of prompts.
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    // Create a list to track responses.
    List<string> _responses = new List<string> {};

    // Create a constuctor for the class.
    public ListAcivity()
    {
        _name = "List Activity";
        _remainingTime = 0;
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
    }

    // Create methods for the ListActivity.
    public string GetRandomPrompt()
    {
        // Get random number.
        Random rnd = new Random();
        int randomInt = rnd.Next(4);
        return _prompts[randomInt];
    }

        public void Run()
    {   
        _responses.Clear();
        DisplayStartingMessage();
        Console.Clear();
        Console.Write("Get ready...  ");
        Console.WriteLine("\r\n\r\nList as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\r\n");
        Console.WriteLine("When you are ready to start, press enter.");
        Console.ReadLine();
        DateTime _startingTime = DateTime.Now;
        DateTime _endingTime = _startingTime.AddSeconds(_duration);
        DateTime _currentTime = DateTime.Now;
        TimeSpan _differenceInSeconds;
        Console.Clear();
        Console.WriteLine("You may begin in: ");
        
        while (_currentTime < _endingTime)
        {
            _currentTime = DateTime.Now;
            _differenceInSeconds = _currentTime - _startingTime;
            _remainingTime = (_duration - (int) _differenceInSeconds.TotalSeconds);
            Console.WriteLine($"\r\n There are {_remainingTime} seconds left in the exersice.\r\n");
            Console.Write("> ");
            _responses.Add(Console.ReadLine());
        }
        Console.WriteLine("Here are your listed items:");
        foreach (string response in _responses)
        {
            Console.WriteLine($"> {response}");
        }
        Console.WriteLine("When you are ready to continue, press enter.");
        Console.ReadLine();
        DisplayEndingMessage();
    }
}   