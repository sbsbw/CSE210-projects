using System;

public class Menu
{
    // Create attribute for menu options.
    List<string> menuOptions = new List<string> {"1. Start breathing activity", "2. Start reflecting activity", "3. Start listing activity", "0. Quit"};

    public int DisplayMenu()
    {   
        Console.Clear();
        Console.WriteLine("Menu Options:");
        foreach (string option in menuOptions)
        {
            Console.WriteLine($" {option}");
        }
        Console.Write("Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }
}