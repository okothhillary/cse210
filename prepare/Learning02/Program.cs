using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Soft";
        job1._companyName = "Flow Yetu";
        job1._startYear = "2022";
        job1._endYear = "Infinity";

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._companyName = "FlowX";
        job2._startYear = "2021";
        job2._endYear = "2022";

        Resume resume = new Resume();
        resume._name = "Hillary Okoth";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
        
}