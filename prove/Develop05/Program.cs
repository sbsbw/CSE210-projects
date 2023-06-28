using System;

class Program
{
    static void Main(string[] args)
    {
        // Start by creating a menu and goalData object.
        GoalData GD = new GoalData();
        Menu M = new Menu();

        int userChoice = -1;
        int goalNumber = 0;
        while (userChoice != 0)
        {
            Console.WriteLine();
            Console.WriteLine($"Your score is currently: {GD.GetXP()}");
            userChoice = M.DisplayMainMenu();

            if (userChoice == 1)
            {
                GD.AddGoal();
            }
            else if (userChoice == 2)
            {
                GD.ShowGoals();
            }
            else if (userChoice == 3)
            {
                Console.Write("Please type a file name: ");
                string fileName = Console.ReadLine();
                GD.Save(fileName);
            }
            else if (userChoice == 4)
            {
                Console.Write("Please type a file name: ");
                string fileName = Console.ReadLine();
                GD.Load(fileName);
            }
            else if (userChoice == 5)
            {
                GD.ShowGoals();
                Console.Write("Which goal did you accomplish? ");
                goalNumber = int.Parse(Console.ReadLine());
                GD.CompleteGoal(goalNumber);
            }
            else if (userChoice == 0)
            {
                Console.WriteLine("\r\nThank you for using the Goal program.");
            }

        }
    }
}