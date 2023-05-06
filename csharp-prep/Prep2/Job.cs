using System;

class Job
{
    public string _name;
    public string _jobTitle;
    public string _description;
    public string _startYear;
    public string _endYear;
       public void Display()
    {
        Console.WriteLine($"Job Title:{_jobTitle}  Job descriptiion: {_description} Start Year: {_startYear} End year: {_endYear}");
    }
}