using System;

public class ReflectingActivity : Activity
{
    // Create a list of questions.
    private List<string> _questions = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // Create a list of prompts.
    private List<string> _prompts = new List<string>()
    {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
    };

    // Create a constuctor for the class.
    public ReflectingActivity(int duration)
    {
        _name = "Reflecting Activity";
        _duration = duration;
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    // Create methods for the ListActivity.
    public string GetRandomPrompt()
    {
        // Get random number.
        Random rnd = new Random();
        int randomInt = rnd.Next(3);
        return _prompts[randomInt];
    }

    public string GetRandomQuestion()
    {
        // Get random number.
        Random rnd = new Random();
        int randomInt = rnd.Next(8);
        return _prompts[randomInt];
    }
}