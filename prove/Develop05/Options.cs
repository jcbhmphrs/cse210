public class Options
{

   public static List<string> _editor = new List<string>() { "Load Goal File", "Add New Goal", "Complete a Goal", "Save Goals", "View All Goals", "QUIT" };
    
    internal static void OptionDisplay(List<string> optionList)
    {
        optionList.ForEach(option => { Console.Write($"({option})     "); });
        Console.Write("\n\nType an option... ");
    
    }


    
}