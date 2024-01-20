using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who did you smile at today?",
            "What did you eat for breakfast and why?",
            "Did you overcome a problem today, what was it?",
            "What was the best thing that happened to you today?",
            "Did anyone brighten your day, or did you brighten someone else's?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
