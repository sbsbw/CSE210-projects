using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for scripture reference.
        Console.WriteLine("Please enter a scripture reference in the shown format: (1Nephi_3_7.txt or Proverbs_3_5-6.txt)");
        string fileName = Console.ReadLine();

        // Define attributes for menu.
        bool finished = false;

        // Create a new scripture.
        Scripture currentScripture = new Scripture(fileName);

        
        // Create a while loop to determine if the program should continue.
        while (!finished)
        {
            Console.Clear(); // This will clear the screen.
            currentScripture.PrintTheScripture();
            
            Console.WriteLine("\r\n \r\nPress enter to continue or type 'q' to quit.");
            string input = Console.ReadLine();
            if (input == "q")
            {
                finished = true;
            }
            else
            {
                if (currentScripture.AllWordsHidden())
                {
                    finished = true;
                }
                else
                {
                    currentScripture.HideRandomWord();
                }
            }
        }
    }
}