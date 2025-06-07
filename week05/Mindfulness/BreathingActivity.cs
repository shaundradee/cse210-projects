using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
    )
    {
    }

    public void InhaleCountDown()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void HoldCountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
    public void ExhaleCountDown()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void RunBreathingActivity()
    {
        //needs to loop length of duration user entered
        Console.Write("Activity starting in... ");
        CountDown();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            InhaleCountDown();
            Console.Write("\nHold");
            HoldCountDown();
            Console.Write("\nBreathe out...");
            ExhaleCountDown();
            Console.Clear();
        }
        Console.WriteLine("\n--------------------------\n");
    }
}