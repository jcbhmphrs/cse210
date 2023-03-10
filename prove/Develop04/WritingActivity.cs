internal class WritingActivity : Activity
{
    private List<string> _prompts = new List<string>() {
        "Who are people that you appreciate?",
        "When have you felt the Holy Ghost this week?",
        "What thought has helped you the most this week?"
    };
    public WritingActivity() : base("Writing Activity", "This will help you reflect on the good things in your life by having you write as many things as you can in a certain area.") { }
    public void StartActivity()
    {
        Welcome();
        Console.WriteLine(_prompts[_random.Next(_prompts.Count() - 1)]);
        Console.WriteLine("Take a moment to ponder the prompt displayed above.");
        Animation(15);
        Console.Clear();
        Console.WriteLine("Ok, now press enter to begin your list. Press enter after typing each item in your list.");
        Console.Read();
        int listItems = 0;
        string userListInput;
        ActivityStartTime = DateTime.Now;
        while (DateTime.Now < ActivityStartTime.AddSeconds(Duration))
        {
            userListInput = Console.ReadLine();
            Console.Clear();
            listItems ++;
        }
        Console.WriteLine($"You wrote {listItems} items in {Duration} seconds!");
        EndingMessage();
    }
}