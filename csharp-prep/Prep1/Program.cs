using System;

class Program
{
    static void Main(string[] args)
    {
        // First we will assign the variables.
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        // We will now use the first and last name the user gave to tell them their name on the console.
        Console.WriteLine($"\nYour name is {last}, {first} {last}.");

    }
}