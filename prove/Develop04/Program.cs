using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a while loop to repeat game until user is finished.
        int userChoice = -1;
        while (userChoice != 0)
        {
            // Create a new menu and display it to choose and option.
            Menu mainMenu = new Menu();
            userChoice = mainMenu.DisplayMenu();

            

            // Activity test = new Activity();
            // test.GetDuration();
            // test.ShowCountdownTimer();
        }
    }
}