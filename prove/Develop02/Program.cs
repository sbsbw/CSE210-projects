using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   
        // Choose a starting journal.
        Console.Write("What journal would you like to start in? ");
        string fileName = Console.ReadLine();
        Journal CurrentJournal = new Journal();
        CurrentJournal._journalName = fileName;
        CurrentJournal.Load(fileName);


        int option = 0;
        while (option != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("  1. Write");
            Console.WriteLine("  2. Display");
            Console.WriteLine("  3. Load");
            Console.WriteLine("  4. Save");
            Console.WriteLine("  5. Quit");
            Console.Write("What would you like to do? ");
            try
            {
            string choice = Console.ReadLine();
            option = int.Parse(choice);
            }
            catch
            {
                Console.WriteLine("Your input was not valid.");
                option = 0;
            }

            // Create if statements in order to call funtions defined in our other classes.
            if (option == 1)
            {
                JournalEntry entry = new JournalEntry(GetPrompt());
                CurrentJournal._journalEntries.Add(entry);
            }
            else if (option == 2)
            {
                CurrentJournal.Display();
            }
            else if (option == 3)
            {
                Console.Write("What is the Journal name? ");
                fileName = Console.ReadLine();
                CurrentJournal = new Journal();
                CurrentJournal._journalName = fileName;
                CurrentJournal.Load(fileName);
            }
            else if (option == 4)
            {
                Console.Write("What is the Journal name? ");
                fileName = Console.ReadLine();
                CurrentJournal.Save(fileName);
            }
            else
            {
                Console.WriteLine("Thank you for using the Journal program.");
            }
        }
    }

    // Create a function that assigns a prompt the prompt.
    static string GetPrompt()
    {
        // Create a list with prompts.
        string [] prompts = {"What is something kind someone did for you?", "What was you favorite part of the day?", "What is something you are grateful for today?", "Was there any important conversation that you had today?", "What emotion did you feel the most today and why?"};
        
        // Use GetRandomNumber method to assign a number for the prompt.
        int promptNumber = GetRandomNumber();
        string prompt = prompts[promptNumber];
        return prompt;
    }
    
    static int GetRandomNumber()
    {
        // Use Random to generate a number for choosing a daily prompt.
        Random rnd = new Random();
        int number = rnd.Next(4);
        return number;
    }

}