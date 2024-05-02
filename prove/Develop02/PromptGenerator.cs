using System;

public class PromptGenerator
{

    public string[] _prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "When was the last time I let someone know how thanksful I was for them?",
        "What has caused me to feel inspired today?",
        "How can I respond to a challenge I am experiencing today in a positive way?",
        "If I could write a text to inspire my kids what would it be?",
        "When did I feel joy today??",
        "What is one thing I know as a fact today?",
        "In what ways have I changed or grown lately?",
        "How can I view today as a gift?",
        "What/who do I cherish?"
    };

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Length);
        return _prompts[index];
    }
}
