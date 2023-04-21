using System;

class Program
{
    static void Main(string[] args)
    {   
        // Promt user for their grade.
        Console.Write("What is your grade? ");
        string answer = Console.ReadLine();
        float grade = float.Parse(answer);
        
        // Create a series of if statements to tell user thier grade.
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is {letter}.");

        // Tell use whether they passed the class or not.
        if (grade >= 70)
        {
            Console.WriteLine($"You passed the class!");
        }
        else
        {
            Console.WriteLine($"You failed the class.");
        }
    }
}