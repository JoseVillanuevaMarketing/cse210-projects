using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone.",
        "Think of a time when you did something selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "What made it different?",
        "How can you apply this again?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "Reflect on times you showed strength and resilience.";
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("\nThink about it...");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine("\n" + question);
            ShowSpinner(4);
        }

        EndMessage();
    }
}