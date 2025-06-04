using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();


    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have demonstrated strength and resilience. It will guide you to recognize your inner power and explore how you can apply it to other areas of your life.")
    {
        AddPrompts();
        AddQuestions();
    }

    public void AddPrompts()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Remember a moment when you learned something valuable about yourself.");
        _prompts.Add("Reflect on a moment when someone showed you unexpected kindness.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you felt God's presence in your life.");
        _prompts.Add("Remember a time when you stayed strong under pressure.");
        _prompts.Add("Recall a moment when you helped someone in need.");
    }

    public void AddQuestions()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("What strengths or values did you draw on during this time?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("Would you respond differently if this happened again? Why or why not?");
        _questions.Add("What did you learn about yourself from this moment?");
        _questions.Add("How can you keep this experience in mind in the future?");
        _questions.Add("What message would you share with someone going through something similar?");
        _questions.Add("How did you feel during and after the experience?");
        _questions.Add("How did God influence your thoughts or actions during this experience?");
    }

    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    // public string GetRandomQuestion()
    // {
    //     int index = _random.Next(_questions.Count);
    //     return _questions[index];
    // }

    // public void DisplayRandomPrompt()
    // {
    //     Console.WriteLine(GetRandomPrompt());
    // }

    // public void DisplayRandomQuestion()
    // {
    //     Console.WriteLine(GetRandomQuestion());
    // }

    public List<string> GetShuffledQuestions()
    {
        var random = new Random();
        var shuffled = new List<string>(_questions);

        for (int i = shuffled.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            // Swap
            var temp = shuffled[i];
            shuffled[i] = shuffled[j];
            shuffled[j] = temp;
        }

        return shuffled;
    }

    // public void RunReflectingActivity()
    // {
    //     Console.Write("Activity starting in... ");
    //     CountDown();
    //     Console.WriteLine();
    //     GetRandomPrompt();
    //     PauseAnimation();

    //     DateTime start = DateTime.Now;
    //     DateTime end = start.AddSeconds(GetDuration());

    //     while (DateTime.Now < end)
    //     {
    //         DisplayRandomQuestion();
    //         PauseAnimation();
    //     }

    // }
    public void RunReflectingActivity()
    {
        Console.Write("Starting in... ");
        CountDown();
        Console.WriteLine("\n--------------------------");

        Console.WriteLine(GetRandomPrompt());
        PauseAnimation();
        Console.WriteLine();

        // Shuffle the questions once
        List<string> shuffledQuestions = GetShuffledQuestions();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration());

        int questionIndex = 0;

        while (DateTime.Now < end && questionIndex < shuffledQuestions.Count)
        {
            Console.WriteLine(shuffledQuestions[questionIndex]);
            PauseAnimation();
            questionIndex++;
        }
        Console.WriteLine("\n--------------------------\n");
    }

}





