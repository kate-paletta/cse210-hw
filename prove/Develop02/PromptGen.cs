using System;
using System.Collections.Generic;
public class PromptGen
{
    public List<string> _prompts = new List<string>
    {
        "What was something fun that you did today?",
        "What is your goal for this week?",
        "Did you talk to anyone interesting today?",
        "What is one of your dream vacations?",
        "What is something that you did that was better than yesterday?",
        "What is something you are looking forward to?",
        "Did you do any of your hobbies today?",
        "What is something the Spirit taught you this week?",
        "Did you have a scripture that stuck out to you this week of Come Follow Me?",
        "What are you grateful for?"
    };
    Random random = new Random();
    
    public string GetRandomPrompt()
    {
        int _promptPick = random.Next(_prompts.Count);
        return _prompts[_promptPick];
    }
}