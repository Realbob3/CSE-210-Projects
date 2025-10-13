using System;


public class Job
{
    public string JobTitle;
    public string Company;
    public int StartYear;
    public int EndYear;

    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}
public class Resume
{
    public string Name;
    public List<Job> Jobs = new List<Job>(); 

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");

    
        foreach (Job job in Jobs)
        {
            job.Display();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.JobTitle = "Software Developer";
        job1.Company = "Valve";
        job1.StartYear = 2017;
        job1.EndYear = 2020;

        Job job2 = new Job();
        job2.JobTitle = "Sales representative";
        job2.Company = "Samsung";
        job2.StartYear = 2020;
        job2.EndYear = 2024;

        Resume resume1 = new Resume();
        resume1.Name = "John Resume";

        resume1.Jobs.Add(job1);
        resume1.Jobs.Add(job2);

        resume1.Display();
    }
}