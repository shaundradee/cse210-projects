using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Mass Construction";
        job1._jobTitle = "Sales Coordinator";
        job1._startYear = 2014;
        job1._endYear = 2017;

        Job job2 = new Job();

        job2._company = "Allwood Landscaping";
        job2._jobTitle = "Gardener";
        job2._startYear = 2006;
        job2._endYear = 2012;

        Resume myResume = new Resume();
        myResume._name = "Melvin McLovin";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}