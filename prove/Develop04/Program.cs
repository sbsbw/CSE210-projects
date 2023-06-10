using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a while loop to repeat game until user is finished.
        int userChoice = -1;

        // Create an instance of every activity.
        BreathingAcivity BActivity = new BreathingAcivity();
        ReflectingActivity RActivity = new ReflectingActivity();
        

        while (userChoice != 0)
        {
            // Create a new menu and display it to choose and option.
            Menu mainMenu = new Menu();
            userChoice = mainMenu.DisplayMenu();

            if (userChoice == 1)
            {
                BActivity.Run();
            }
            else if (userChoice == 2)
            {
                RActivity.Run();
            }
        }
    }
}