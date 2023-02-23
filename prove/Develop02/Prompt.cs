using System;

public class Prompt
{
    static List<string> prompts = new List<string>()
    {
    "What am I grateful for today?",
    "A positive word that describes my day.",
    "What will I do differently tomorrow?",
    "What or who made me the happiest today?",
    "Three things that have inspired me today.",
    "One thing I can do to brighten someone else's day.",
    "How did I give and recieve appreciation today?",
    "What is a big win from today?",
    "What is something that I may take for granted?",
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
    };

    static Random random = new Random();
    public string text = prompts[random.Next(0, prompts.Count - 1)];

}