using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1_jobtitle = "Software Developer";
        job1_company = "Valve";
        job1_startyear = 2017;
        job1_endyear = 2020;

        job job2 = new job();
        job2_jobtitle = "Sales representative";
        job2_company = "Samsung";
        job2_startyear = 2020;
        job2_endyear = 2024;

        resume resume1 = new resume();
        resume1_name = "John Resume";

        resume1_jobs.add(job1);
        resume1_jobs.add(job2);

        resume1.Display();
    }
}