using System;

public class JournalEntry
{
    // Assign date to current day.
    public string _date;

    // Create a variable for the prompt and user input.
    public string _prompt;
    public string _entryText;
    public JournalEntry(){}

    // create function to get text from user.
    public JournalEntry(string chosenPrompt)
    {
        _date = DateTime.Today.ToString();
        _prompt = chosenPrompt;
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.Write("Type your entry here: ");
        // Have user input entry.
        _entryText = Console.ReadLine();
    }
    public void EntryDisplay()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_entryText}\n");
    }
}