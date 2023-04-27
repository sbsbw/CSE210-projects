using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    // Define your number variable and your Numbers list.
    List<int> numbers = new List<int>();

    // Have the user populate the list of numbers.
    int numberToAdd = -1;
    Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    while (numberToAdd != 0)
    {
        Console.Write("Enter number: ");
        numberToAdd = int.Parse(Console.ReadLine());
        numbers.Add(numberToAdd);
    }
    // Define sum, average, and max variable.
    int sum = 0;
    float avg = 0;
    int max = 0;
    foreach (int i in numbers)
    {
        sum = sum + i;
        if (i > max)
        {
            max = i;
        }
    }
    int count = (numbers.Count - 1);
    avg = (sum / count);

    // Print sum, avg, and max.
    Console.WriteLine($"The sum is : {sum}");
    Console.WriteLine($"The average is : {avg}");
    Console.WriteLine($"The max is : {max}");

    }
}