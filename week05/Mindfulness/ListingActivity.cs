using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private int _count;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by guiding you to list as many items as you can within a specific area.")
    {
        AddListingPrompts();
    }

    public void AddListingPrompts()
    {
        _prompts.Add("What talents or hobbies bring you joy?");
        _prompts.Add("What are things that bring you peace or comfort?");
        _prompts.Add("When have you felt the presence or guidance of the Holy Ghost this month?");
        _prompts.Add("What are blessings in your life that you're grateful for today?");
        _prompts.Add("What things in nature inspire or calm you?");
        _prompts.Add("Who has made a positive impact on your life?");
        _prompts.Add("What moments recently brought you a sense of Heavenly Father's love?");
    }

    public string GetRandomListingPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void RunListingActivity()
    {
        Console.Write("Activity starting in... ");
        CountDown();
        Console.WriteLine();
        Console.WriteLine(GetRandomListingPrompt());
        PauseAnimation();
        Console.WriteLine("\n--------------------------");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration());

        Console.WriteLine("Begin Listing.");

        _count = 0;

        while (DateTime.Now < end)
        {
            string input = Console.ReadLine();
            _count ++;
        }
        Console.WriteLine($"\nAwesome! You entered {_count} entries!");
        Console.WriteLine("\n--------------------------\n");
    }

}