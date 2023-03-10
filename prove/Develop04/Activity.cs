using System;
internal class Activity
{
    protected DateTime ActivityStartTime { get; set; }
    protected string ActivityType { get; set; } //property
    protected string ActivityDescription { get; set; } //property
    protected int Duration { get; set; } //property
    protected Random _random = new Random();

    public Activity(string activityType, string activityDescription)
    {
        ActivityType = activityType;
        ActivityDescription = activityDescription;
    }

    protected void Welcome()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {ActivityType}\n{ActivityDescription}");
        Console.Write("How long, in seconds, would you like your session to be? - ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
        Animation(3);
        Console.Clear();
    }

    protected void EndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well Done!");
        Animation(3);
    }



    protected void DisplayTimer(int seconds)
    {
        int counter = seconds;
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(counter);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            counter--;
        }
    }
    protected void Animation(int duration)
    {
        Console.CursorVisible = false;
        int AnimationStartingLine = Console.CursorTop;
        string[] frames = { """
        + + + 
        +   + 
        o + + 
        """, """
        + + + 
        o   + 
        + + + 
        """, """
        o + + 
        +   + 
        + + + 
        """, """
        + o + 
        +   + 
        + + + 
        """, """
        + + o 
        +   + 
        + + + 
        """, """
        + + + 
        +   o 
        + + + 
        """, """
        + + + 
        +   + 
        + + o 
        """, """
        + + + 
        +   + 
        + o + 
        """ };
        for (int i = 0; i < duration; i++)
        {
            foreach (string frame in frames)
            {
                Console.Write(frame);
                Thread.Sleep(100);
                Console.SetCursorPosition(0, AnimationStartingLine);
            }
        }
        Console.CursorVisible = true;
    }
}