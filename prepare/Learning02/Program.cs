using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Goodwill";
        job1._jobTitle = "Retail Supervisor";
        job1._startYear = 2021;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "I-State Truck";
        job2._jobTitle = "Branch Administrator";
        job2._startYear = 2022;
        job2._endYear = 2024;

        // job1.DisplayJob();
        // job2.DisplayJob();

        Resume resume1 = new Resume();
        resume1._name = "Kate Paletta";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}