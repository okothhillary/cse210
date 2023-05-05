using System;

public class Job
{
    //member variables:
    public string _companyName;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses
    // public Jobs()
    // {
    // }

    //behaviours or methods
    public void Display()
    {
        Console.WriteLine($"{_jobTitle}({_companyName}) {_startYear}-{_endYear}");
    }

}