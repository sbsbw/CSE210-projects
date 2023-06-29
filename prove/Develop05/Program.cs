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
            int currentXP = GD.GetXP();
            float unroundedTier = (currentXP / 3000);
            int tier = (int)Math.Ceiling(unroundedTier);
            
            // Do a strech that gives you ranks.
            if (((currentXP - (3000 * tier)) / 500) >= 0 &&  ((currentXP - (3000 * tier)) / 500) < 2)
            {
                Console.WriteLine($"Your score is currently: {currentXP}. You are a tier {tier} novice.");
            }
            else if (((currentXP - (3000 * tier)) / 500) >= 2 &&  ((currentXP - (3000 * tier)) / 500) < 3)
            {
                Console.WriteLine($"Your score is currently: {currentXP}. You are a tier {tier} Tradesman.");
            }
            else if (((currentXP - (3000 * tier)) / 500) >= 3 &&  ((currentXP - (3000 * tier)) / 500) < 4)
            {
                Console.WriteLine($"Your score is currently: {currentXP}. You are a tier {tier} Knight.");
            }
            else if (((currentXP - (3000 * tier)) / 500) >= 4 &&  ((currentXP - (3000 * tier)) / 500) < 5)
            {
                Console.WriteLine($"Your score is currently: {currentXP}. You are a tier {tier} Noble.");
            }
            else if (((currentXP - (3000 * tier)) / 500) >= 5 &&  ((currentXP - (3000 * tier)) / 500) < 6)
            {
                Console.WriteLine($"Your score is currently: {currentXP}. You are a tier {tier} Royal.");
            }

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