using System;

public class Menu
{
    // Create attribute for menu options.
    List<string> mainMenuOptions = new List<string> {"1. Create income/expense.", "2. Show balance.", "3. List incomes.", "4. List expenses.", "5. List all.", "6. Pay expense.", "7. Return expense.", "8. Save budget.", "9. Load budget.", "0. Quit"};
    // List<string> saveOrLoadMenuOptions = new List<string> {"1. Use Default file name.", "2. Get new file name.", "0. Quit"};
    List<string> incomeOrExpenseMenuOptions = new List<string> {"1. Income", "2. Wages", "3. Expense", "4. Consistant Expense", "5. Refundable Expense", "0. Quit"};

    public int DisplayMainMenu()
    {   
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        foreach (string option in mainMenuOptions)
        {
            Console.WriteLine($" {option}");
        }
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
    // public int DisplaySaveOrLoadMenu()
    // {   
    //     Console.WriteLine("Here are the following file options:");
    //     foreach (string option in saveOrLoadMenuOptions)
    //     {
    //         Console.WriteLine($"  {option}");
    //     }
    //     Console.Write("Select a choice from the menu: ");
    //     int choice = int.Parse(Console.ReadLine());
    //     return choice;
    // }
    public int DisplayincomeOrExpenseMenu()
    {   
        Console.WriteLine();
        Console.WriteLine("Here are the following file options:");
        foreach (string option in incomeOrExpenseMenuOptions)
        {
            Console.WriteLine($"  {option}");
        }
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
}