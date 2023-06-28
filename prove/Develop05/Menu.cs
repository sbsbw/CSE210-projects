using System;

public class Menu
{
    // Create attribute for menu options.
    List<string> mainMenuOptions = new List<string> {"1. Create new goal.", "2. List goals.", "3. Save goals.", "4. Load goals.", "5. Record goals.", "0. Quit"};
    List<string> goalMenuOptions = new List<string> {"1. Simple goal.", "2. Eternal goal.", "3. checklist goal.", "0. Quit"};

    public int DisplayMainMenu()
    {   
        Console.WriteLine("Menu Options:");
        foreach (string option in mainMenuOptions)
        {
            Console.WriteLine($" {option}");
        }
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
    public int DisplayGoalMenu()
    {   
        Console.WriteLine("The types of goals are:");
        foreach (string option in goalMenuOptions)
        {
            Console.WriteLine($"  {option}");
        }
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
}