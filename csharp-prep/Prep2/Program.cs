using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._name = "John";
        job1._jobTitle = "Developer";
        job1._description = "Develops things";
        job1._startYear = "2010";
        job1._endYear = "2015";
        job1.Display();

        Job job2 = new Job();   
        job2._name = "John";
        job2._jobTitle = "Developer";
        job2._description = "Develops things";
        job2._startYear = "2010";
        job2._endYear = "2015";
        job2.Display();

        
        Resume resume = new Resume();
        resume._name = "John";
        resume._jobs = new List<Job>();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }
}