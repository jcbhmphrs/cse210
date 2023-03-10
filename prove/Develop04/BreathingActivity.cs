internal class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }
    public void StartActivity()
    {
        Welcome();
        ActivityStartTime = DateTime.Now;
        while (DateTime.Now < ActivityStartTime.AddSeconds(Duration))
        {
            Console.Clear();
            // Console.WriteLine($"while loop init - \n.now = {DateTime.Now}. \nstart+duration = {ActivityStartTime.AddSeconds(Duration)}");
            Console.CursorVisible = false;
            Console.WriteLine("Breath in");
            DisplayTimer(6);
            Console.WriteLine("Hold");
            DisplayTimer(3);
            Console.WriteLine("Breath out");
            DisplayTimer(6);
            Console.WriteLine("Hold");
            DisplayTimer(3);

        }
        EndingMessage();
        Console.CursorVisible = true;
    }
}