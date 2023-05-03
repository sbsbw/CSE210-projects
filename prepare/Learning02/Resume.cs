using System;

public class Resume
{
    public string _name;

    // Make a list and initialize it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Use a for loop to display jobs.
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}