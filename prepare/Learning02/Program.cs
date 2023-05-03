using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "microsoft";
        job1._jobTitle = "software engineer";
        job1._startYear = 2024;
        job1._endYear = 2029;

        Job job2 = new Job();
        job2._company = "apple";
        job2._jobTitle = "software engineer";
        job2._startYear = 2029;
        job2._endYear = 2040;

        Resume resume1 = new Resume();
        resume1._name = "Sean Walker";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}