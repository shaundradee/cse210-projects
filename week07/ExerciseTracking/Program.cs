using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running r1 = new Running(30, 4);
        activities.Add(r1);

        Swimming s1 = new Swimming(40, 3);
        activities.Add(s1);

        Cycling c1 = new Cycling(20, 25);
        activities.Add(c1);

        Console.WriteLine();

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        
        Console.WriteLine();
    }
}