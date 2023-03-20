using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Animation loadingAnimation = new Animation();
        loadingAnimation.Run(250, 100, 15);
        void EditorMenu()
        {
            Console.Clear();
            GoalManager goalManager = new GoalManager();
            bool userContinue = true;
            while (userContinue)
            {
                Console.WriteLine($"$ {goalManager.Wallet}\n");
                Options.OptionDisplay(Options._editor);
                switch (Console.ReadLine().ToLower())
                {
                    case "quit":
                        userContinue = false;
                        break;
                    case "load goal file":
                        goalManager.LoadFromCSV();
                        break;
                    case "add new goal":
                        goalManager.AddGoal();
                        break;
                    case "complete a goal":
                        goalManager.CompleteGoal();
                        break;
                    case "save goals":
                        goalManager.SaveGoals();
                        break;
                    case "view all goals":
                        goalManager.ShowGoals();
                        break;
                    default:
                        Console.Write("Not a valid input.\nPress any key to Continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        EditorMenu();
    }
}