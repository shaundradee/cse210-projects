using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "3form";
        job1._jobTitle = "Sales Coordinator";
        job1._startYear = 2014;
        job1._endYear = 2017;
        job1.Display();

        Job job2 = new Job();

        job2._company = "Lowe's";
        job2._jobTitle = "Kitchen and Bath Designer";
        job2._startYear = 2006;
        job2._endYear = 2012;
        job2.Display();
        


    }
}