using System;

class Program
{
    static void Main(string[] args)
    {
        // First we will ask the user for a magic number.
        // Console.Write("\nWhat is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // Use random number generator to choose a random magic number.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // Declare the guess variable.
        int guess = 0;
        
        // Create a while loop to repeat the user guessing.
        while (guess != magicNumber)
        {
            // Have the user input a guess.
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // Create an if statement to tell user whether they need to go higher or lower.
            if (guess > magicNumber)
            {
                Console.Write("Lower\n");
            }

            else if (guess < magicNumber)
            {
                Console.Write("Higher\n");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}