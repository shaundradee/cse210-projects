using System;
using System.Collections.Generic;


public class PromptGen
{
    public List<string> _prompts = new List<string>
    {
        "What made you smile today?",
        "What are three things that you are grateful for?",
        "What is something that you accomplished today?",
        "What is one thing that you are looking forward to this week?",
        "Where did you see the hand of the Lord in your life today?"
    };

    public Random _randomQ = new Random();

    public string GetRandomPrompt()
    {
        int index = _randomQ.Next(_prompts.Count);
        return _prompts[index];
    }

}